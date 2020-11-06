using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoYcomunicacionExterna.subVentanasScript
{
    public class MetodosTipoString
    {
        public int[] ObtenerTamaño(string t1, string t2)
        {
            int[] T = { t1.Length, t2.Length };
            return T;
        }
        public string ObtenerConcatenado(string[] t)
        {
            return string.Concat(t);
        }
        public int indexOf(string txt, string input)
        {
            return txt.IndexOf(input);
        }
        public string Remplazar(string txt, string[] txtVN)
        {
            try
            {
                return txt.Replace(txtVN[0], txtVN[1]);
            }catch(Exception e)
            {
                return "error general";
            }
            
        }
        public int[] Comparar(string[] txt)
        {
            int neta = string.Compare(txt[0], txt[1], false);
            int NoNneta = string.Compare(txt[0], txt[1], true);
            int Ordenal = string.CompareOrdinal(txt[0], txt[1]);
            int[] res = { neta, NoNneta, Ordenal };
            return res;
        }
        public string[] Podar(string[] txt)
        {
            string[] ResTxt = { txt[0].Trim(), txt[1].Trim() };
            return ResTxt;
        }
        public bool Igualar(string[] Txt)
        {
            return Txt[0].Equals(Txt[1]);
        }
        public string substring(string txt, int r1, int r2)
        {
            return txt.Substring(r1, r2);
        }
        public string split(string txt, char ctc, bool i)
        {
            if (i)
            {
                string[] parts = txt.Split(ctc);
                string salida = "";
                foreach (string partS in parts)
                {
                    salida += partS + "\n";
                }
                return salida;
            }
            else
            {
                string[] parts = txt.Split(ctc);
                string salida = "";
                foreach (string partS in parts)
                {
                    salida += partS;
                }
                return salida;
            }
            
        }
        public string[] split(string txt, char ctc)
        {
            string[] parts = txt.Split(ctc);
            return parts;
        }
        public char charAt(string txt, int chAr)
        {
            if(chAr < txt.Length)
            {
                return txt[chAr];
            }
            else
            {
                return '#';
            }
            
        }
        public bool startWith(string txt, string pref)
        {
            return txt.StartsWith(pref);
        }
        public bool endWith(string txt, string suf)
        {
            return txt.EndsWith(suf);
        }
    }
}
