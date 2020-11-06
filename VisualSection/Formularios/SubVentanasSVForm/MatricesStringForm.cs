using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualSection.Properties;
using MidSection.SubVentanasScripts;

namespace VisualSection.Formularios.SubVentanasSVForm
{
    public partial class MatricesStringForm : Form
    {
        public MatricesStringForm()
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

        EasyGeter datos = new EasyGeter();
        MidMatricesString MMS = new MidMatricesString();

        private void CerrarBtnIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CerrarBtnPanel_MouseEnter(object sender, EventArgs e)
        {
            CerrarBtnPanel.BackColor = Settings.Default.colorSelect;
            CerrarBtnIcon.BackColor = Settings.Default.colorSelect;
        }

        private void CerrarBtnPanel_MouseLeave(object sender, EventArgs e)
        {
            CerrarBtnPanel.BackColor = Settings.Default.colorBase;
            CerrarBtnIcon.BackColor = Settings.Default.colorBase;
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            string[,] DatosGenericos = { { "123456", "DE LA CRUZ", "JORGE", "15-09-10", "VENTAS", "2500"/*5*/, "3", "5", "300", "400"}, 
                { "258741", "DURAN" , "ARNALDO", "15-09-10", "SISTEMAS", "2000", "3", "5", "100", "250"}, 
                { "654318", "AVILA" , "JOHAN", "15-09-10", "ALMACEN", "1800", "3", "5", "100", "100"},
                { "780012", "CLAVIJO", "ISMAEL", "15-09-10", "CONTABILIDAD", "3000", "3", "5", "200", "500"},
                { "123456", "DE LA CRUZ", "JORGE", "30-09-10", "VENTAS", "2500", "3", "5", "400", "400"},
                { "258741", "DURAN" , "ARNALDO", "30-09-10", "SISTEMAS", "2000", "3", "5", "200", "250"},
                { "654318", "AVILA" , "JOHAN", "30-09-10", "ALMACEN", "1800", "3", "5", "100", "100"},
                { "780012", "CLAVIJO", "ISMAEL", "30-09-10", "CONTABILIDAD", "3000", "3", "5", "200", "500"},
                { "123456", "DE LA CRUZ", "JORGE", "15-10-10", "VENTAS", "2500", "3", "5", "300", "400"},
                { "258741", "DURAN" , "ARNALDO", "15-10-10", "SISTEMAS", "2000", "3", "5", "100", "250"},
                { "654318", "AVILA" , "JOHAN", "15-10-10", "ALMACEN", "1800", "3", "5", "200", "100"},
                { "780012", "CLAVIJO", "ISMAEL", "15-10-10", "CONTABILIDAD", "3000", "3", "5", "100", "500"},
                { "123456", "DE LA CRUZ", "JORGE", "30-10-10", "VENTAS", "2500", "3", "5", "200", "400"},
                { "258741", "DURAN" , "ARNALDO", "30-10-10", "SISTEMAS", "2000", "3", "5", "100", "250"},
                { "654318", "AVILA" , "JOHAN", "30-10-10", "ALMACEN", "1800", "3", "5", "100", "100"},
                { "780012", "CLAVIJO", "ISMAEL", "30-10-10", "CONTABILIDAD", "3000", "3", "5", "300", "500"}
            };

            string[] texts = new string[10];

            for(int i = 0; i < 16; i++)
            {
                datos.SetAtributes(DatosGenericos[i, 0], DatosGenericos[i, 1], DatosGenericos[i, 2],
                    DatosGenericos[i, 3], DatosGenericos[i, 4], DatosGenericos[i, 5], DatosGenericos[i, 6],
                    DatosGenericos[i, 7], DatosGenericos[i, 8], DatosGenericos[i, 9]);
                texts = datos.GetTexts("MSF");
                MMS.Mid_Guardar(texts);
                texts = null;
            }
        }

        private void EnviarBtn_Click(object sender, EventArgs e)
        {
            datos.SetAtributes(cedulaIn, PATxt, PNTxt, FPD, FPM, FPA, DepTxt, SBIn, DesEPSIn,
                DesPenIn, DesAntIn, DesPreIn);//esta sobrecarga es exclusiva de este metodo y el de arriva :)
            string[] DatosTxt = datos.GetTexts("MSF");
            MMS.Mid_Guardar(DatosTxt);
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            datos.SetAtributes(ConsultaItemTxt, ConD, ConM, ConA);
            string[] datoS = MMS.Mid_Consultar(datos.GetTexts("CT"));
            //mensaje de error
            if (datoS[0][0] == 'n' || datoS[0][0] == 'd')
            {
                MessageBox.Show(datoS[0]);
            }
            else
            {
                CedCon.Value = int.Parse(datoS[0]);
                PACon.Text = datoS[1];
                PNCon.Text = datoS[2];
                string[] dma = datoS[3].Split('-');
                FPDCon.Value = int.Parse(dma[0]);
                FPMCon.Value = int.Parse(dma[1]);
                FPACon.Value = int.Parse(dma[2]);
                DepCon.Text = datoS[4];
                SBCon.Value = int.Parse(datoS[5]);
                DesEPSCon.Value = int.Parse(datoS[6]);
                DesPen.Value = int.Parse(datoS[7]);
                DesAntCon.Value = int.Parse(datoS[8]);
                DesPreCon.Value = int.Parse(datoS[9]);
                SalNetCon.Value = int.Parse(datoS[10]);
            }
        }

        private void Impresion1_Click(object sender, EventArgs e)
        {
            datos.SetAtributes(ConsultaItemTxt, ConD, ConM, ConA);
            string[] datoS = MMS.Mid_Consultar(datos.GetTexts("CT"));
            string i = datoS[0];
            
            if (i[0] == 'd' || i[0] == 'n')
            {
                MessageBox.Show(i);
            }
            else
            {
                string mensaje = MMS.Mid_ImpresionXquincena(datoS[0], datoS[3]);
                MessageBox.Show(mensaje);
            }
        }

        private void ImpresionXmes_Click(object sender, EventArgs e)
        {
            datos.SetAtributes(ConsultaItemTxt, ConD, ConM, ConA);
            string[] datoS = MMS.Mid_Consultar(datos.GetTexts("CT"));
            string i = datoS[0];

            if (i[0] == 'd' || i[0] == 'n')
            {
                MessageBox.Show(i);
            }
            else
            {
                string mensaje = MMS.Mid_ImpresionXmes(datoS[0], ImpresionCombo.SelectedItem.ToString());
                MessageBox.Show(mensaje);
            }
        }

        private void ImpresionXmeses_Click(object sender, EventArgs e)
        {
            datos.SetAtributes(ConsultaItemTxt, ConD, ConM, ConA);
            string[] datoS = MMS.Mid_Consultar(datos.GetTexts("CT"));
            string i = datoS[0];

            if (i[0] == 'd' || i[0] == 'n')
            {
                MessageBox.Show(i);
            }
            else
            {
                string mensaje = MMS.Mid_ImpresionXmeses(datoS[0]);
                MessageBox.Show(mensaje);
            }
        }
    }
}
