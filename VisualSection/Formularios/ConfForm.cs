using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSection.Formularios
{
    public partial class ConfForm : Form
    {
        public ConfForm()
        {
            InitializeComponent();
            panelPrincipal.BackColor = Properties.Settings.Default.Fondo;
        }
        ConfDiseño Diseño = new ConfDiseño();

        private void GrisBtn_Click(object sender, EventArgs e)
        {
            Diseño.gris();
            Diseño.Aplicar();
        }

        private void AzulBtn_Click(object sender, EventArgs e)
        {
            Diseño.Azul();
            Diseño.Aplicar();
        }

        private void HeladitosBtn_Click(object sender, EventArgs e)
        {
            Diseño.Heladitos();
            Diseño.Aplicar();
        }
    }
}
