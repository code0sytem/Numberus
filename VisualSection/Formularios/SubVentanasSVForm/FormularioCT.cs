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
using VisualSection.Properties;

namespace VisualSection.Formularios.SubVentanasSVForm
{
    public partial class FormularioCT : Form
    {
        public FormularioCT()
        {
            InitializeComponent();
            ActualizarDiseño();
        }
        private void ActualizarDiseño()
        {
            subVentanilla.BackColor = Settings.Default.colorBase;
            cerrarPanel.BackColor = Settings.Default.colorBase;
            panel1.BackColor = Settings.Default.Fondo;
        }

        MidMetodosTipoString ObjMTS = new MidMetodosTipoString();
        EasyGeter Textos = new EasyGeter();

        private void cerrarBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ME_cerrar(object sender, EventArgs e)
        {
            cerrarIcon.BackColor = Color.IndianRed;
            cerrarPanel.BackColor = Color.IndianRed;
        }

        private void ML_cerrar(object sender, EventArgs e)
        {
            cerrarIcon.BackColor = Color.LightSteelBlue;
            cerrarPanel.BackColor = Color.LightSteelBlue;
        }

        private void ObtenerTamañoBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string[] Txt = Textos.GetTexts("CT");
            string[] Tamaños = ObjMTS.ObtenerTamaño_Mid(Txt[0], Txt[1]); //se envian los textos y se obtiene en forma de arreglo los tamaños de los textos enviados
            OTtextResult1.Text = Tamaños[0];
            OTtextResult2.Text = Tamaños[1];
        }

        private void ConcatenarBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string[] Txt = Textos.GetTexts("CT");
            ConcattextResult.Text = ObjMTS.ObtenerConcatenado_Mid(Txt);
        }

        private void sizeOfBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string Txt = Textos.GetTexts(indexOfComboBox);
            string Input = indexOfCharInput.Text;
            indexOfResult.Text = ObjMTS.indexOf_Mid(Txt, Input);
        }

        private void RemplazarBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string[] Txt = Textos.GetTexts(RemplazarComboBox, true);
            string[] TxtVN = { TxtViejo.Text, TxtNuevo.Text };
            if (Txt[1] == "Txt1")
            {
                Text1.Text = ObjMTS.Remplazar_Mid(Txt[0], TxtVN);
            }
            else
            {
                Text2.Text = ObjMTS.Remplazar_Mid(Txt[0], TxtVN);
            }
        }

        private void compararBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string[] Txt = Textos.GetTexts("CT");
            string[] resultados = ObjMTS.Comparar_Mid(Txt);
            compararRT.Text = resultados[0];
            compararRTN.Text = resultados[1];
            compararRTO.Text = resultados[2];
        }

        private void podarBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string[] Txt = Textos.GetTexts("CT");
            string[] ResTxt = ObjMTS.Podar_Mid(Txt);
            Text1.Text = ResTxt[0];
            Text2.Text = ResTxt[1];
        }

        private void IgualarBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string[] Txt = Textos.GetTexts("CT");
            IgualarTxt.Text = ObjMTS.Igualar_mid(Txt);
        }

        private void subStringBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string Txt = Textos.GetTexts(subCombo);
            subres.Text = ObjMTS.substring_Mid(Txt, r1.Text, r2.Text);
        }

        private void SplitBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string Txt = Textos.GetTexts(SplitCombo);
            string ctc = SplitCTC.Text;
            MessageBox.Show(ObjMTS.split_Mid(Txt, ctc), "SPLIT");
        }

        private void charAtBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string Txt = Textos.GetTexts(charAtCombo);
            CA_CE.Text = ObjMTS.charAt_Mid(Txt, IndiceCABuscar.Text);
        }

        private void startWithBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string Txt = Textos.GetTexts(startCombo);
            rstar.Text = ObjMTS.startWith_Mid(Txt, pref.Text);
        }

        private void endWithBtn_Click(object sender, EventArgs e)
        {
            Textos.SetAttributes(Text1, Text2);
            string Txt = Textos.GetTexts(endCombo);
            rend.Text = ObjMTS.endWith_Mid(Txt, suf.Text);
        }
    }
}
