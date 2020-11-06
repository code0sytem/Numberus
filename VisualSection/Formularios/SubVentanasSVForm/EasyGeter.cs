using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSection.Formularios.SubVentanasSVForm
{
    public class EasyGeter
    {
        private string[] Error = { "error", "error" };
        private string[] texts = new string[2];
        private string[] MSFTexts = new string[11];

        public void SetAttributes(TextBox a, TextBox b)
        {
            texts[0] = a.Text;
            texts[1] = b.Text;
        }
        public void SetAttributes(string x)
        {
            texts[0] = x;
        }
        public string GetText()
        {
            return texts[0];
        }
        public void SetAtributes(NumericUpDown a, TextBox b, TextBox c,
            NumericUpDown dD, NumericUpDown dM, NumericUpDown dA, TextBox e, NumericUpDown f, NumericUpDown g, 
            NumericUpDown h, NumericUpDown i, NumericUpDown j)
        {
            MSFTexts[0] = a.Value.ToString();
            MSFTexts[1] = b.Text.Replace(' ', '_');
            MSFTexts[2] = c.Text.Replace(' ', '_');
            string Aux = "";
            if (Int16.Parse(dM.Value.ToString()) < 10)
            {
                Aux = "0";
            }
            MSFTexts[3] = dD.Value.ToString() + "-" + Aux + dM.Value.ToString() + "-" + dA.Value.ToString();
            MSFTexts[4] = e.Text;
            MSFTexts[5] = f.Value.ToString();
            MSFTexts[6] = (double.Parse(g.Value.ToString()) * double.Parse(MSFTexts[5])).ToString();
            MSFTexts[7] = (double.Parse(h.Value.ToString()) * double.Parse(MSFTexts[5])).ToString();
            MSFTexts[8] = i.Value.ToString();
            MSFTexts[9] = j.Value.ToString();
            MSFTexts[10] = (int.Parse(MSFTexts[5]) -
                (int.Parse(MSFTexts[6]) + int.Parse(MSFTexts[7]) +
                int.Parse(MSFTexts[8]) + int.Parse(MSFTexts[9]))).ToString();
        }

        public void SetAtributes(string a, string b, string c,
            string d, string e, string f, string g,
            string h, string i, string j)
        {
            MSFTexts[0] = a;
            MSFTexts[1] = b.Replace(' ', '_');
            MSFTexts[2] = c.Replace(' ', '_');
            MSFTexts[3] = d;
            MSFTexts[4] = e;
            MSFTexts[5] = f;
            MSFTexts[6] = ((double.Parse(g) / 100) * double.Parse(MSFTexts[5])).ToString();
            MSFTexts[7] = ((double.Parse(h) / 100) * double.Parse(MSFTexts[5])).ToString();
            MSFTexts[8] = i;
            MSFTexts[9] = j;
            MSFTexts[10] = (int.Parse(MSFTexts[5]) - (int.Parse(MSFTexts[6]) + int.Parse(MSFTexts[7]) + int.Parse(MSFTexts[8]) + int.Parse(MSFTexts[9]))).ToString();
        }

        public void SetAtributes(TextBox a, NumericUpDown D, NumericUpDown M, NumericUpDown A)
        {
            texts[0] = a.Text;
            string Aux = "";
            if (Int16.Parse(M.Value.ToString())<10)
            {
                Aux = "0";
            }
            texts[1] = D.Value.ToString() + "-" + Aux + M.Value.ToString() + "-" + A.Value.ToString();

        }

        public string[] GetTexts(string val)
        {
            switch (val)
            {
                case "CT": return texts;
                case "MSF": return MSFTexts;
                default: return Error;
            }
            
        }
        
        public string GetTexts(ComboBox CB)
        {
            try
            {
                if (CB.SelectedItem.ToString() == "Txt1")
                {
                    return texts[0];
                }
                else
                {
                    return texts[1];
                }
            }
            catch(NullReferenceException e)
            {
                MessageBox.Show("Item no seleccionado", "ERROR - 376");
                return "";
            }
        }
        public string[] GetTexts(ComboBox CB, bool i)
        {
            if (CB.SelectedItem.ToString() == "Txt1")
            {
                string[] text= { texts[0], CB.SelectedItem.ToString() };
                return text;
            }
            else
            {
                string[] text = { texts[1], CB.SelectedItem.ToString() };
                return text;
            }
        }
    }
}
