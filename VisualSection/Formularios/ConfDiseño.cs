using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using VisualSection.Properties;

namespace VisualSection.Formularios
{
    public class ConfDiseño
    {
        private Color ColorBase;
        private Color ColorSelect;
        private Color ColorFondo;

        public ConfDiseño()
        {
            ColorBase = Settings.Default.colorBase;
            ColorSelect = Settings.Default.colorSelect;
            ColorFondo = Settings.Default.Fondo;
        }
        public void Aplicar()
        {
            Settings.Default.colorBase = ColorBase;
            Settings.Default.colorSelect = ColorSelect;
            Settings.Default.Fondo = ColorFondo;
            
        }
        public void Azul()
        {
            ColorBase = Color.LightSteelBlue;
            ColorSelect = Color.CornflowerBlue;
            ColorFondo = Color.Lavender;
        }
        public void gris()
        {
            ColorBase = Color.DimGray;
            ColorSelect = Color.DarkGray;
            ColorFondo = Color.Gainsboro;
        }

        public void Heladitos()
        {
            ColorBase = Color.FromArgb(255, 155, 249);
            ColorSelect = Color.FromArgb(254, 188, 255);
            ColorFondo = Color.FromArgb(155, 255, 255);
        }
        
    }
}
