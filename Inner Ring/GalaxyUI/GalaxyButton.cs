using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaxyUI
{
    public partial class GalaxyButton: UserControl
    {
        private string _texto = "Boton";
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

        public GalaxyButton()
        {
            InitializeComponent();
        }

        private void GalaxyButton_Load(object sender, EventArgs e)
        {
            label.Text = _texto;
            label.ForeColor = _tema.ObtenerColor(_nombreTema, false);
            pictureBox.Image = _tema.ObtenerLinea(_nombreTema, false);
        }

        private void CambiarColorActivo(object sender, EventArgs e)
        {
            label.ForeColor = _tema.ObtenerColor(_nombreTema, true);
            pictureBox.Image = _tema.ObtenerLinea(_nombreTema, true);
        }

        private void CambiarColorNormal(object sender, EventArgs e)
        {
            label.ForeColor = _tema.ObtenerColor(_nombreTema, false);
            pictureBox.Image = _tema.ObtenerLinea(_nombreTema, false);
        }

        //private Color _colorPrevio = Color.FromArgb(255, Color.Yellow);
        //private Color _colorNormal = Color.Yellow;
        //private Color _colorActivo = Color.DodgerBlue;

        //public Color ColorNormal
        //{
        //    get { return _colorNormal; }
        //    set { _colorNormal = value; }
        //}

        //public Color ColorActivo
        //{
        //    get { return _colorActivo; }
        //    set { _colorActivo = value; }
        //}

        //private void CambiarColor(Color colorNuevo)
        //{
        //    Bitmap bmp = new Bitmap(pictureBox.Image);
        //    for (var x = 0; x < bmp.Width; x++)
        //    {
        //        for (var y = 0; y < bmp.Height; y++)
        //        {
        //            if (bmp.GetPixel(x, y) == _colorPrevio)
        //            {
        //                bmp.SetPixel(x, y, colorNuevo);
        //            }
        //        }
        //    }

        //    pictureBox.Image = bmp;
        //    label.ForeColor = colorNuevo;
        //    _colorPrevio = Color.FromArgb(255, colorNuevo);
        //}
    }
}
