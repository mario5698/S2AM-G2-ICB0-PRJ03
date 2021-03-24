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
    public partial class GalaxyTextBox : UserControl
    {
        private string _texto = "Introduce algo";
        ThemeName _nombreTema = ThemeName.Vitruvian;
        GalaxyTheme _tema;

        public string Texto
        {
            get { return _texto; }
            set { _texto = value; }
        }

        public ThemeName Tema
        {
            get { return _nombreTema; }
            set { _nombreTema = value; }
        }

        public GalaxyTextBox()
        {
            InitializeComponent();
        }

        private void GalaxyTextBox_Load(object sender, EventArgs e)
        {
            textBox.Text = _texto;
            pictureBox.Image = _tema.ObtenerTexto(_nombreTema, false);
            textBox.BackColor = _tema.ObtenerColor(_nombreTema, false);
            textBox.ForeColor = _tema.ObtenerColorTexto(_nombreTema, false);
        }

        private void CambiarColorActivo(object sender, EventArgs e)
        {
            pictureBox.Image = _tema.ObtenerTexto(_nombreTema, true);
            textBox.BackColor = _tema.ObtenerColor(_nombreTema, true);
            textBox.ForeColor = _tema.ObtenerColorTexto(_nombreTema, true);
        }

        private void CambiarColorNormal(object sender, EventArgs e)
        {
           pictureBox.Image = _tema.ObtenerTexto(_nombreTema, false);
            textBox.BackColor = _tema.ObtenerColor(_nombreTema, false);
            textBox.ForeColor = _tema.ObtenerColorTexto(_nombreTema, false);
        }
    }
}
