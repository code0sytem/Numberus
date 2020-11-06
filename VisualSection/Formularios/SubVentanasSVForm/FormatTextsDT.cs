using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidSection.SubVentanasScripts;

namespace VisualSection.Formularios.SubVentanasSVForm
{
    public partial class FormatTextsDT : Form
    {
        FormatTexts_Mid FTM = new FormatTexts_Mid();
        EasyGeter EG = new EasyGeter();
        public FormatTextsDT()
        {
            InitializeComponent();
            txtsCB.DataSource = FTM.BuscarArchivos();
        }

        private void cerrarIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeerBtn_Click(object sender, EventArgs e)
        {
            string txt = FTM.Leer(txtsCB.SelectedItem.ToString());
            TextoOriginal.Text = txt;
            EG.SetAttributes(txt);
        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {
            if (ContadorCaracterCB.Checked)
            {
                MessageBox.Show("Caracteres encontrados: " + 
                    FTM.ContadorCaracteres_Mid(EG.GetText()));
            }
            if (ContadorNumericoCB.Checked)
            {
                MessageBox.Show("Numeros encontrados: " + 
                    FTM.ContadorNumerico_Mid(EG.GetText()));
            }
            if (ContadorLetrasCB.Checked)
            {
                MessageBox.Show("Letras encontradas: " + FTM.ContadorLetras_Mid(EG.GetText()));
            }
        }
    }
}
