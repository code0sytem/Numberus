using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualSection.Properties;
using MidSection.SubVentanasScripts;
using MidSection.SubVentanasScripts.ExtraCode_PH;

namespace VisualSection.Formularios.SubVentanasSVForm
{
    public partial class ParcialHeladeria : Form
    {
        public ParcialHeladeria()
        {
            InitializeComponent();
            ActualizarDiseño();
        }

        public void ActualizarDiseño()
        {
            panel1.BackColor = Settings.Default.colorBase;
            CerrarBtnPanel.BackColor = Settings.Default.colorBase;
            panel2.BackColor = Settings.Default.Fondo;
        }

        ParcialHeladeria_Mid PHM = new ParcialHeladeria_Mid();
        private PHM_Obj PO = new PHM_Obj();

        private void CerrarBtnIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CerrarBtnPanel_MouseEnter(object sender, EventArgs e)
        {
            CerrarBtnPanel.BackColor = Settings.Default.colorSelect;
        }

        private void CerrarBtnPanel_MouseLeave(object sender, EventArgs e)
        {
            CerrarBtnPanel.BackColor = Settings.Default.colorBase;
        }

        private void VainillaBtn_Click(object sender, EventArgs e)
        {
            VainillaRadioButton.Select();
        }

        private void ChocolateBtn_Click(object sender, EventArgs e)
        {
            ChocolateRadioButton.Select();
        }

        private void FresaBtn_Click(object sender, EventArgs e)
        {
            FresaRadioButton.Select();
        }

        private void limonBtn_Click(object sender, EventArgs e)
        {
            limonCheckBox.Select();
        }

        private void chicleBtn_Click(object sender, EventArgs e)
        {
            chicleCheckBox.Select();
        }

        private void cookiesBtn_Click(object sender, EventArgs e)
        {
            cookiesCheckBox.Select();
        }

        private void conoBtn_Click(object sender, EventArgs e)
        {
            conoCheckBox.Select();
        }

        private void basitoBtn_Click(object sender, EventArgs e)
        {
            basitoCheckBox.Select();
        }

        private void arequipeBtn_Click(object sender, EventArgs e)
        {
            if (!ArequipeCB.Checked) ArequipeCB.Checked = true;
            else ArequipeCB.Checked = false;
        }

        private void chipsBtn_Click(object sender, EventArgs e)
        {
            if (!chipsCB.Checked) chipsCB.Checked = true;
            else chipsCB.Checked = false;
        }

        private void cerealesBtn_Click(object sender, EventArgs e)
        {
            if (!cerealesCB.Checked) cerealesCB.Checked = true;
            else cerealesCB.Checked = false;
        }

        private void gomitasBtn_Click(object sender, EventArgs e)
        {
            if (!GomitasCB.Checked) GomitasCB.Checked = true;
            else GomitasCB.Checked = false;
        }

        private void nutellaBtn_Click(object sender, EventArgs e)
        {
            if (!nutelaCB.Checked) nutelaCB.Checked = true;
            else nutelaCB.Checked = false;
        }

        private void maniBtn_Click(object sender, EventArgs e)
        {
            if (!maniCB.Checked) maniCB.Checked = true;
            else maniCB.Checked = false;
        }

        private void AbrirForm(object x)
        {
            Form formulario = x as Form;
            formulario.ShowDialog();
        }

        private void FormaEntragaBtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new ExtraSections_PH.FormaEntregaPH());
        }

        private void FormaPagoBtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new ExtraSections_PH.FormaPagoPH());
        }

        private void GuardarDC_Click(object sender, EventArgs e)
        {
            int aux;
            string sabor,recipiente;
            ArrayList adicional = new ArrayList();

            if (string.IsNullOrEmpty(nombreTextBox.Text.Trim()))
            {
                MessageBox.Show("Datos no guardados\nintroduzca su nombre correctamente");
                return;
            }else if (string.IsNullOrEmpty(telefonoTextBox.Text.Trim()) || !(int.TryParse(telefonoTextBox.Text, out aux)))
            {
                MessageBox.Show("Datos no guardados\nintroduzca su telefono correctamente");
                return;
            }
            else if (string.IsNullOrEmpty(correoTextBox.Text.Trim()) || !correoTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Datos no guardados\nintroduzca su correo correctamente");
                return;
            }
            else if (string.IsNullOrEmpty(direccionTextBox.Text.Trim()))
            {
                MessageBox.Show("Datos no guardados\nintroduzca su direccion correctamente");
                return;
            }
            else if (string.IsNullOrEmpty(cedulaTextbox.Text.Trim()) || !(int.TryParse(cedulaTextbox.Text.Trim(), out aux)))
            {
                MessageBox.Show("Datos no guardados\nintroduzca su cedula correctamente");
                return;
            }
            //
            
            //
            if (VainillaRadioButton.Checked)
            {
                sabor = "vainilla";
            }
            else if (ChocolateRadioButton.Checked)
            {
                sabor = "chocolate";
            }
            else if (FresaRadioButton.Checked)
            {
                sabor = "fresa";
            }
            else if (limonCheckBox.Checked)
            {
                sabor = "limon";
            }
            else if (chicleCheckBox.Checked)
            {
                sabor = "chicle";
            }
            else if (cookiesCheckBox.Checked)
            {
                sabor = "coockies";
            }
            else
            {
                MessageBox.Show("Datos no guardados\nPor favor elija un sabor");
                return;
            }

            if (conoCheckBox.Checked)
            {
                recipiente = "cono";
            }
            else if (basitoCheckBox.Checked)
            {
                recipiente = "basito";
            }
            else if (copaCheckBox.Checked)
            {
                recipiente = "copa";
            }
            else
            {
                MessageBox.Show("Datos no guardados\nPor favor seleccione su recipiente");
                return;
            }

            //

            if (ArequipeCB.Checked)
            {
                adicional.Add("Arequipe");
            }
            if (chipsCB.Checked)
            {
                adicional.Add("Chips");
            }
            if (cerealesCB.Checked)
            {
                adicional.Add("Cereales");
            }
            if (GomitasCB.Checked)
            {
                adicional.Add("Gomitas");
            }
            if (nutelaCB.Checked)
            {
                adicional.Add("Nutella");
            }
            if (maniCB.Checked)
            {
                adicional.Add("Mani");
            }
            //
            try
            {
                PHM.recepcionDatosClientes(nombreTextBox.Text, telefonoTextBox.Text,
                correoTextBox.Text, direccionTextBox.Text, cedulaTextbox.Text);
                if (adicional.Count == 0)
                {
                    PHM.recepcionDatosSabor(sabor, recipiente, int.Parse(NdeHelados.Value.ToString()) - 1);
                }
                else
                {
                    PHM.recepcionDatosSabor(sabor, recipiente, adicional,
                        int.Parse(NdeHelados.Value.ToString()) - 1);
                }
                MessageBox.Show("Datos guardados correctamente");
            }catch(Exception ev)
            {
                MessageBox.Show("Error: " + ev);
            }
            adicional.Clear();
        }

        private void VERBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PHM.Imprimir(int.Parse(NdeHelados.Value.ToString())-1));
        }

        private void copaBtn_Click(object sender, EventArgs e)
        {
            if (!copaCheckBox.Checked) copaCheckBox.Checked = true;
            else copaCheckBox.Checked = false;
        }

        private void EfecCompBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PO.guardarEstadoVentas();
                MessageBox.Show("ventas efectuadas correctamente");
            }
            catch(Exception es)
            {
                MessageBox.Show("Error: " + es);
            }
            
        }

        private void visualizarDiaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PO.getVentasDia());
        }

        private void formatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PO.format(true);
                MessageBox.Show("lista formateada correactamente");
            }
            catch(Exception et)
            {
                MessageBox.Show("Error: " + et);
            }
        }
    }
}
