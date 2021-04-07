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


namespace SpaceManager
{
    public partial class LoginManager : Form
    {
        Encrypt cry;
        Acceso acc;
        public LoginManager()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            acc = new Acceso();
            cry = new Encrypt();

            string user = txtUsername.Text;
            string password = txtPassword.Text;

            string rango = "", acc_level = "";
            string tabla = "users";
            //string consulta = "select * from "+ tabla +" where login = '" + user + "' and password = '" + password + "'";

            string query = "select * from " + tabla + " where login = '" + user + "'";
            DataSet set = acc.PortarPerConsulta(query, tabla);
            string salDB = set.Tables[0].Rows[0]["salt"].ToString();
            string passwordDB = set.Tables[0].Rows[0]["Password"].ToString();

            //byte[] bSal = cry.ToBytes(salDB);
            //byte[] bPassLocal = cry.Hash(txtPassword.Text, bSal);

            //string passwordHash = cry.ToString(bPassLocal);
            //bool log = passwordHash == passwordDB;

            //string consulta = "select * from " + tabla + " where login = '" + user + "' and password = '" + passwordHash + "'";



            if (acc.LoginCorrecto(user, password))
            {
                string consulta = String.Format(
                "select * from {0} where login = '{1}' and password = '{2}'",
                tabla, user, password);
                DataSet dts = acc.PortarPerConsulta(consulta, tabla);
                rango = dts.Tables[0].Rows[0]["idUserCategory"].ToString();
                string table = "UserCategories";
                string cons = "select AccessLevel from " + table + " where idUserCategory = " + rango;
                DataSet dt = acc.PortarPerConsulta(cons, table);
                acc_level = dt.Tables[0].Rows[0]["AccessLevel"].ToString();
                ControlManager obj = new ControlManager(user, acc_level);
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o Contraseña incorrecta",
                    "ERROR",
                    MessageBoxButtons.OK
                );
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
