using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyUI
{
    public enum ThemeName
    {
        Vitruvian,
        Fortuna,
        Igni
    }

    public struct GalaxyTheme
    {
       public Color ObtenerColor(ThemeName tema, bool activo)
       {
            if (activo)
            {
                if (tema == ThemeName.Vitruvian) return Color.FromArgb(255,197,164);
                else if (tema == ThemeName.Fortuna) return Color.PaleGreen;
                else return Color.FromArgb(unchecked((int)0xff88001b));
            }
            else
            {
                if (tema == ThemeName.Vitruvian) return Color.FromArgb(243, 255, 143);
                else if (tema == ThemeName.Fortuna) return Color.FromArgb(unchecked((int)0xff3f48cc));
                else return Color.FromArgb(unchecked((int)0xff00cdcd));
            }
       }

        public Color ObtenerColorTexto(ThemeName tema, bool activo)
        {
            if (activo)
            {
                if (tema == ThemeName.Vitruvian) return Color.White;
                else if (tema == ThemeName.Fortuna) return Color.Black;
                else return Color.White;
            }
            else
            {
                if (tema == ThemeName.Vitruvian) return Color.Black;
                else if (tema == ThemeName.Fortuna) return Color.White;
                else return Color.Black;
            }
        }

        public Bitmap ObtenerFondo(int index)
        {
            if (index == 1)
            {
                return new Bitmap(Properties.Resources.bg_3);
            }
            else if (index == 2)
            {
                return new Bitmap(Properties.Resources.bg_3);
            }
            else
            {
                return new Bitmap(Properties.Resources.bg_3);
            }
        }

        public Bitmap ObtenerLinea(ThemeName tema, bool activo)
        {
            if (activo)
            {
                if (tema == ThemeName.Vitruvian) return new Bitmap(Properties.Resources.line_1B);
                else if (tema == ThemeName.Fortuna) return new Bitmap(Properties.Resources.line_2B);
                else return new Bitmap(Properties.Resources.line_3B);
            }
            else
            {
                if (tema == ThemeName.Vitruvian) return new Bitmap(Properties.Resources.line_1A);
                else if (tema == ThemeName.Fortuna) return new Bitmap(Properties.Resources.line_2A);
                else return new Bitmap(Properties.Resources.line_3A);
            }
        }

        public Bitmap ObtenerPanel(ThemeName tema, bool activo)
        {
            if (activo)
            {
                if (tema == ThemeName.Vitruvian) return new Bitmap(Properties.Resources.panel_1B);
                else if (tema == ThemeName.Fortuna) return new Bitmap(Properties.Resources.panel_2B);
                else return new Bitmap(Properties.Resources.panel_3B);
            }
            else
            {
                if (tema == ThemeName.Vitruvian) return new Bitmap(Properties.Resources.panel_1A);
                else if (tema == ThemeName.Fortuna) return new Bitmap(Properties.Resources.panel_2A);
                else return new Bitmap(Properties.Resources.panel_3A);
            }
        }

        public Bitmap ObtenerTexto(ThemeName tema, bool activo)
        {
            if (activo)
            {
                if (tema == ThemeName.Vitruvian) return new Bitmap(Properties.Resources.text_1B);
                else if (tema == ThemeName.Fortuna) return new Bitmap(Properties.Resources.text_2B);
                else return new Bitmap(Properties.Resources.text_3B);
            }
            else
            {
                if (tema == ThemeName.Vitruvian) return new Bitmap(Properties.Resources.text_1A);
                else if (tema == ThemeName.Fortuna) return new Bitmap(Properties.Resources.text_2A);
                else return new Bitmap(Properties.Resources.text_3A);
            }
        }
    }
}
