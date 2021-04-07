using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceManager
{
    public partial class ControlManager : Form
    {
        ControlPlanet plc = new ControlPlanet();
        ControlSpaceShip spc = new ControlSpaceShip();
        ControlDeliveryData ddc = new ControlDeliveryData();


        public ControlManager(string user, string rank)
        {
            InitializeComponent();
        }

        private void ShowForms(Form myForm)
        {
            pnl_data.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.Size = new Size(pnl_data.Width/2, pnl_data.Height);
            myForm.AutoSize = true;
            pnl_data.Controls.Add(myForm);
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowForms(plc);
        }

        private void pnl_data_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForms(spc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForms(ddc);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
