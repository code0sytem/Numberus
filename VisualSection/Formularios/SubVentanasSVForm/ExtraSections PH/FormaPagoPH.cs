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
    public partial class FormaPagoPH : Form
    {
        public FormaPagoPH()
        {
            InitializeComponent();
        }

        private void CerrarBtnIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PHM_Obj PO = new PHM_Obj();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ventanilla_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guardarDatosBtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (ContadoRB.Checked) check = true;
            else if (targetaCreditoRB.Checked) check = true;
            else if (targetaDebitoRB.Checked) check = true;
            else if (chequeRB.Checked) check = true;
            else if (bitcoinRB.Checked) check = true;
            //
            if (check)
            {
                PO.setPrecioTotal(double.Parse(precioValue.Text));
                MessageBox.Show("Datos guardados correctamente"+"\nDescuento de concurso del "+PO.getVoteNum());
                this.Close();
            }
            else { MessageBox.Show("No se ha seleccionado ningun metodo de pago"); return; }

        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            double desc;
            if (ContadoRB.Checked) desc = -0.02;
            else if (targetaCreditoRB.Checked) desc = 0.05;
            else if (targetaDebitoRB.Checked) desc = 0.03;
            else if (chequeRB.Checked) desc = 0.01;
            else if (bitcoinRB.Checked) desc = -0.03;
            else { MessageBox.Show("No se ha seleccionado ningun metodo de pago"); return; }
            precioValue.Text = (PO.getPrecioTotal() + (PO.getPrecioTotal() * desc + -(PO.getVoteNum()/100))).ToString();
        }
    }
}
