using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using VisualSection.Formularios.SubVentanasSVForm;

namespace VisualSection.Formularios
{
    public partial class VentanaPrincipalForm : Form
    {
        public VentanaPrincipalForm()
        {
            InitializeComponent();
            AbrInterForm(new Formularios.SubVentanasSVForm.Inicial());
            ActualizarDiseño();
        }
        private void ActualizarDiseño()
        {
            this.VentanillaMovible.BackColor = Properties.Settings.Default.colorBase;
            this.MinimizePanel.BackColor = Properties.Settings.Default.colorBase;
            this.Xpanel.BackColor = Properties.Settings.Default.colorBase;
            this.XpictureBox.BackColor = Properties.Settings.Default.colorBase;
            this.MinimizePictureBox.BackColor = Properties.Settings.Default.colorBase;
            this.OptionsDisplayer.BackColor = Properties.Settings.Default.colorBase;
            this.OptionsDisplayerPanel.BackColor = Properties.Settings.Default.colorBase;
            this.OptionsPanel.BackColor = Properties.Settings.Default.colorBase;
            this.ControlesTextos.BackColor = Properties.Settings.Default.colorBase;
            this.CTIcon.BackColor = Properties.Settings.Default.colorBase;
            this.CTtxt.BackColor = Properties.Settings.Default.colorBase;
            this.ConfigBtn.BackColor = Properties.Settings.Default.colorBase;
            this.MatricesString.BackColor = Properties.Settings.Default.colorBase;
        }
        //formularioSave guardarForm;

        private void AbrInterForm(object SyS)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
            Form form = SyS as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show(); 
            //guardarForm.Guardar(form);
        }
        private void AbrForm(object SyS)
        {
            Form form = SyS as Form;
            form.ShowDialog();
            ActualizarDiseño();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void VMMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RedLightME(object sender, EventArgs e)
        {
            XpictureBox.BackColor = Color.IndianRed;
            Xpanel.BackColor = Color.IndianRed;
        }

        private void NoNRedLightME(object sender, EventArgs e)
        {
            XpictureBox.BackColor = Properties.Settings.Default.colorBase;
            Xpanel.BackColor = Properties.Settings.Default.colorBase;
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DarkerStyle(object sender, EventArgs e)
        {
            //seleccionado
            MinimizePictureBox.BackColor = Properties.Settings.Default.colorSelect;
            MinimizePanel.BackColor = Properties.Settings.Default.colorSelect;
        }

        private void NoNDarkerStyle(object sender, EventArgs e)
        {
            //defecto
            MinimizePictureBox.BackColor = Properties.Settings.Default.colorBase;
            MinimizePanel.BackColor = Properties.Settings.Default.colorBase;
        }

        private void MinimizarBtn(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OptionDisplayerBtn(object sender, EventArgs e)
        {
            if (OptionsPanel.Width == 76)
            {
                OptionsPanel.Width = 285;
            }
            else
            {
                OptionsPanel.Width = 76;
            }
            
        }

        private void ME_EfectoComun(object sender, EventArgs e)
        {
            CTIcon.BackColor = Properties.Settings.Default.colorSelect;
            ControlesTextos.BackColor = Properties.Settings.Default.colorSelect;
            CTtxt.BackColor = Properties.Settings.Default.colorSelect;
        }

        private void ML_EfectoComun(object sender, EventArgs e)
        {
            CTIcon.BackColor = Properties.Settings.Default.colorBase;
            ControlesTextos.BackColor = Properties.Settings.Default.colorBase;
            CTtxt.BackColor = Properties.Settings.Default.colorBase;
        }

        private void MS_Select(object sender, EventArgs e)
        {
            MatricesString.BackColor = Properties.Settings.Default.colorSelect;
        }

        private void MS_NoNSelect(object sender, EventArgs e)
        {
            MatricesString.BackColor = Properties.Settings.Default.colorBase;
        }

        private void CTIBtn(object sender, EventArgs e)
        {
            AbrInterForm(new FormularioCT());
        }

        private void MatricesString_Click(object sender, EventArgs e)
        {
            AbrInterForm(new MatricesStringForm());
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            AbrForm(new ConfForm());
        }

        private void Setting_enter(object sender, EventArgs e)
        {
            ConfigBtn.BackColor = Properties.Settings.Default.colorSelect;
        }

        private void Setting_leave(object sender, EventArgs e)
        {
            ConfigBtn.BackColor = Properties.Settings.Default.colorBase;
        }

        private void FormatTexts_Click(object sender, EventArgs e)
        {
            AbrInterForm(new FormatTextsDT());
        }

        private void FT_Select(object sender, EventArgs e)
        {
            FormatTexts.BackColor = Properties.Settings.Default.colorSelect;
        }

        private void FT_Leave(object sender, EventArgs e)
        {
            FormatTexts.BackColor = Properties.Settings.Default.colorBase;
        }

        private void ParcialHeladeriaBtn_Click(object sender, EventArgs e)
        {
            AbrInterForm(new ParcialHeladeria());
        }

        private void ParcialHeladeriaBtn_MouseEnter(object sender, EventArgs e)
        {
            ParcialHeladeriaBtn.BackColor = Properties.Settings.Default.colorSelect;
        }

        private void ParcialHeladeriaBtn_MouseLeave(object sender, EventArgs e)
        {
            ParcialHeladeriaBtn.BackColor = Properties.Settings.Default.colorBase;
        }
    }
}
