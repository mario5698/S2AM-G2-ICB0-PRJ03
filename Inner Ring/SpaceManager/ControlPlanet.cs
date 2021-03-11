using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Base;

namespace SpaceManager
{
    public partial class ControlPlanet : Form_Base.Form_base
    {
        public ControlPlanet()
        {
            tabla = "planets";
            order = "descplanet";
            type = "asc";
            id = "idplanet";
            dtg_head = new string[13] {"Id", "Codigo", "Descripcion", "Id Sector", "Longitud", "Latitud", "Parsecs",
                "Id Specie", "Id Filiacion", "IP", "Puerto", "Puerto*",  "Imagen"};
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenImage();
        }
    }
}
