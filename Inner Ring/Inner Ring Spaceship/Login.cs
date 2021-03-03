using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inner_Ring_Spaceship
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Spaceship space = new Spaceship(txt_CodeSpaceship.Text);
            space.Show();
            this.Hide();
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
