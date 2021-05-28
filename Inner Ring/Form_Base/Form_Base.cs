using AccesoDades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlibliotecaG2;
using Controles_Usuario;
using System.IO;  

namespace Form_Base
{
    public partial class Form_base : Form
    {
        Acceso obj;
        Encrypt cry;
        public DataTable infotabla;
        protected string tabla, order, type, id, pic;
        protected bool has_pass = false;
        protected bool nuevo = false;
        protected DataRow row;
        string pass_orig;
        protected string[] dtg_head;
        DataSet dts;
        string query;

        public Form_base()
        {
            InitializeComponent();   
        }

        private void Users_Load(object sender, EventArgs e)
        {
            if (tabla == "spaceships")
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 150, pictureBox1.Location.Y);
            }
            if (DesignMode) return;

            obj = new Acceso();
            cry = new Encrypt(); 
            Portar_Dades();
            Info_Textbox();
            Dtg_header();
            cancel.Hide();
        }

        private void Portar_Dades()
        {
            query = "Select * from " + tabla + " order by " + order + " " + type;
            dts = obj.PortarPerConsulta(query);
            infotabla = dts.Tables[0];
            dtgUsers.DataSource = infotabla;
            dtgUsers.Columns[id].Visible = false;
        }

        private void Dtg_header()
        {
            for (int i = 0; i < dtg_head.Length; i++)
            {
                dtgUsers.Columns[i].HeaderText = dtg_head[i].ToString();
            }
        }

        private void Info_Textbox()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.BackColor = Color.White;
                    ctr.ForeColor = Color.Black;
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    ctr.DataBindings.Add("Text", infotabla, ((SWTextbox)ctr).Nom_BBDD.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!nuevo)
                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            cancel.Show();
            row = infotabla.NewRow();
            nuevo = true;
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty; 
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Info_Textbox();
            cancel.Hide();
        }

        private void Actualizar_Base_Click(object sender, EventArgs e)
        {
            bool vacios = false;
            if (nuevo)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(SWTextbox))
                    {
                        if (((SWTextbox)ctr).obligatorio && ctr.Text == string.Empty)
                        {
                            vacios = true;
                        }
                        else
                        {
                            row[((SWTextbox)ctr).Nom_BBDD.ToString()] = ctr.Text;
                        }
                    }
                }
                if (!vacios)
                {
                    infotabla.Rows.Add(row);
                    nuevo = false;
                    obj.Actualitzar(dts, query);
                    Portar_Dades();
                    Info_Textbox();
                    cancel.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "CAMPOS OBLIGATORIOS VACIOS O TIPO DE DATO INCORRECTO",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                nuevo = false;
                Hash_Pass();
                obj.Actualitzar(dts, query);
                Portar_Dades();
                Info_Textbox();
            }
        }

        private void Hash_Pass()
        {
            if (has_pass)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.Name == "password_swtxb" && ctr.Text != pass_orig)
                    {
                        byte[] sal = cry.Sal();
                        byte[] pass = cry.Hash(ctr.Text, sal);
                        if (nuevo)
                        {
                            infotabla.Rows[dtgUsers.Rows.Count - 1]["salt"] = cry.ToString(sal);
                            infotabla.Rows[dtgUsers.Rows.Count - 1]["Password"] = cry.ToString(pass);
                            pass_orig = infotabla.Rows[dtgUsers.Rows.Count - 1]["Password"].ToString();
                        }
                        else
                        {
                            infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["salt"] = cry.ToString(sal);
                            infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["Password"] = cry.ToString(pass);
                            pass_orig = infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["Password"].ToString();
                        }
                    }
                }
            }
        }

        private void dtgUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (has_pass)
            {
                pass_orig = infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["Password"].ToString();
            }
        }

        protected void OpenImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(Application.StartupPath + "\\images\\" + ofd.SafeFileName);
                infotabla.Rows[dtgUsers.CurrentCell.RowIndex][pic] = ofd.SafeFileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = img;
            }
        }

        private void ChangeImage(Object sender, EventArgs e)
        {
            if (pic != null) {
                foreach (Control ctr in Controls)
                {
                    if (dtgUsers.CurrentCell != null &&
                        infotabla.Rows[dtgUsers.CurrentCell.RowIndex][pic] != DBNull.Value)
                    {
                        string p = Application.StartupPath + "\\images\\" + infotabla.Rows[dtgUsers.CurrentCell.RowIndex][pic].ToString();
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = Image.FromFile(p);
                    }
                }
            }
        }
    }
}