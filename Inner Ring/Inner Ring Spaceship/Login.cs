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

namespace Inner_Ring_Spaceship
{
    public partial class Login : Form
    {
        Acceso Acc = new Acceso();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            checkCode(txt_CodeSpaceship.Text);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_CodeSpaceship_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkCode(txt_CodeSpaceship.Text);
            }
        }

        private void checkCode(string codeSpaceshìp)
        {
            try
            {
                DataSet spaceship;
                spaceship = Acc.PortarPerConsulta("select * from SpaceShips where CodeSpaceShip = "+"'"+codeSpaceshìp+"'");
                int existe = spaceship.Tables[0].Rows.Count;
                if (existe > 0)
                {
                    openForm(codeSpaceshìp);
                }
                else
                {
                    MessageBox.Show("Invalid Code");
                }
            }
            catch (Exception ex )
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
    }
}
