using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaxyUI
{
    public partial class GalaxyPanel : UserControl
    {
        ThemeName _nombreTema = ThemeName.Vitruvian;
        GalaxyTheme _tema;
        public ThemeName Tema
        {
            get { return _nombreTema; }
            set { _nombreTema = value; }
        }

        public GalaxyPanel()
        {
            InitializeComponent();
        }

        private void GalaxyForm_Load(object sender, EventArgs e)
        {
            panel.BackgroundImage = _tema.ObtenerPanel(_nombreTema, false);
        }

        private void CambiarColorActivo(object sender, EventArgs e)
        {
            panel.BackgroundImage = _tema.ObtenerPanel(_nombreTema, true);
        }

        private void CambiarColorNormal(object sender, EventArgs e)
        {
            panel.BackgroundImage = _tema.ObtenerPanel(_nombreTema, false);
        }
    }
}
