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
    public partial class ControlSpaceShip : Form_Base.Form_base
    {
        public ControlSpaceShip()
        {
            tabla = "spaceships";
            order = "codespaceship";
            type = "asc";
            id = "idspaceship";
            pic = "SpaceShipPicture";
            dtg_head = new string[7] {"Id", "Id Tipo de Nave", "Codigo", "IP", "Puerto", "Puerto*",  "Imagen"};
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenImage();
        }
    }
}
