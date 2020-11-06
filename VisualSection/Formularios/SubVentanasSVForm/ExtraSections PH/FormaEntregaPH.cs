using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MidSection.SubVentanasScripts.ExtraCode_PH;

namespace VisualSection.Formularios.SubVentanasSVForm.ExtraSections_PH
{
    public partial class FormaEntregaPH : Form
    {
        public FormaEntregaPH()
        {
            InitializeComponent();
        }

        private PHM_Obj PO = new PHM_Obj();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CerrarBtnIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventanilla_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guardarDatosBtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (RapidRB.Checked) check = true;
            else if (DomiyaRB.Checked) check = true;
            else if (DomiMaRB.Checked) check = true;
            else if (OtroRB.Checked) check = true;
            else if (NullRB.Checked) check = true;
            if (check)
            {
                PO.setPrecioTotal(int.Parse(valorCompra.Text));
                MessageBox.Show("Datos guardados correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Forma de entrega no especificada");
            }
            
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            int a;
            if (RapidRB.Checked)
            {
                if (zonaM.Checked)
                    a = 6000;
                else if (zonaS.Checked)
                    a = 8000;
                else
                    a = 4000;
            }
            else if (DomiyaRB.Checked)
            {
                if (zonaS.Checked || zonaM.Checked)
                    a = 7000;
                else
                    a = 5000;
            }
            else if (DomiMaRB.Checked) a = 5000;
            else if (OtroRB.Checked) a = 4000;
            else a = 0;

            valorCompra.Text = (PO.calculatePrecioTotal() + a).ToString();
        }
    }
}
