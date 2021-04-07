using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDades;
using GalaxyUI;

namespace Inner_Ring_Spaceship
{
    public partial class Login : Form
    {
        int numeroTema;
        ThemeName nombreTema;
        Random rngx = new Random();
        GalaxyTheme tema = new GalaxyTheme();
        Acceso Acc = new Acceso();
        public Login()
        {
            InitializeComponent();
            AsignarTema();
            AsignarFunciones();
        }

        private void AsignarTema()
        {
            numeroTema = rngx.Next(1, 4);
            //numeroTema = 2;
            if (numeroTema == 1) { nombreTema = ThemeName.Vitruvian; }
            else if (numeroTema == 2) { nombreTema = ThemeName.Fortuna; }
            else { nombreTema = ThemeName.Igni; }

            BackgroundImage = tema.ObtenerFondo(numeroTema);


            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = tema.ObtenerColor(nombreTema, false);
                }

                if (c is GalaxyButton)
                {
                    var button = (GalaxyButton)c;
                    button.Tema = nombreTema;
                }
                else if (c is GalaxyTextBox)
                {
                    var text = (GalaxyTextBox)c;
                    text.Tema = nombreTema;
                }
                else if (c is GalaxyPanel)
                {
                    var panel = (GalaxyPanel)c;
                    panel.Tema = nombreTema;
                }
            }
        }

        private void AsignarFunciones()

        {
            btn_galaxy_login.label.Click += checkCodeSpaceship;
            btn_galaxy_login.pictureBox.Click += checkCodeSpaceship;


            btn_galaxy_exit.label.Click += closeForm;
            btn_galaxy_exit.pictureBox.Click += closeForm;
        }



        private void checkCodeSpaceship(object sender, EventArgs e)
        {
            checkCode(txt_galaxi.textBox.Text);
        }


        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }



        private void checkCode(string codeSpaceship)
        {
            try
            {
                DataSet spaceship;
                spaceship = Acc.PortarPerConsulta("select * from SpaceShips where CodeSpaceShip = '" + codeSpaceship + "'");
                int existe = spaceship.Tables[0].Rows.Count;
                if (existe > 0)
                {
                    openForm(codeSpaceship);
                }
                else
                {
                    MessageBox.Show("Invalid Code");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openForm(string codeSpaceship)
        {
            Spaceship space = new Spaceship(codeSpaceship);
            space.Show();
            this.Hide();
        }

        private void galaxyTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkCode(txt_galaxi.textBox.Text);
            }
        }


    }
}
