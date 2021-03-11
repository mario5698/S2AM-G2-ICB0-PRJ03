using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlibliotecaG2
{
    public partial class ObtenerNombreMaquina : TextBox
    {
        public ObtenerNombreMaquina()
        {
            InitializeComponent();
        }

        public String _Nombre_Maquina;
        public String ObtenerNombre
        {
            get { return _Nombre_Maquina; }
            set { _Nombre_Maquina = Environment.MachineName; ; }
        }





    }
}
