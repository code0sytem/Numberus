using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcesamientoYcomunicacionExterna;
using ProcesamientoYcomunicacionExterna.subVentanasScript;

namespace MidSection.SubVentanasScripts
{
    public class MidMetodosTipoString
    {
        MetodosTipoString ObjMTS = new MetodosTipoString();
        public string[] ObtenerTamaño_Mid(string txt1, string txt2)
        {
            //se envia la transformacion de los textos para recibir en un arreglo en formato entero 
            //del tamaño de los textos a el proyecto MetodosTipoString
            int[] Aux = ObjMTS.ObtenerTamaño(txt1, txt2); 
            string[] Aux_ = new string[2];
            //uso de un bucle for para transferir la transformacion del auxiliar entero al auxiliar 
            //multicaracter
            for (int i = 0; i < 2; i++)
            {
                Aux_[i] = Aux[i].ToString();
            }
            Aux = null;//formateo de la informacion en el auxiliar entero
            return Aux_;
        }
        public string ObtenerConcatenado_Mid(string[] txt)
        {
            return ObjMTS.ObtenerConcatenado(txt);
        }
        public string indexOf_Mid(string txt, string Input)
        {
            int IO = ObjMTS.indexOf(txt, Input);
            if (IO >= 0)
            {
                return IO.ToString();
            }
            else
            {
                return "DATO NO VALIDO";
            }
        }
        public string Remplazar_Mid(string txt, string[] txtVN)
        {
            return ObjMTS.Remplazar(txt, txtVN);
        }
        public string[] Comparar_Mid(string[] txts)
        {
            int[] IntRes = ObjMTS.Comparar(txts);
            string[] Res = { IntRes[1].ToString(), IntRes[0].ToString(), 
                IntRes[2].ToString() };
            return Res;
        }
        public string[] Podar_Mid(string[] txt)
        {
            return ObjMTS.Podar(txt);
        }
        public string Igualar_mid(string[] txt)
        {
            bool va = ObjMTS.Igualar(txt);
            if (va == true)
            {
                return "Datos equivalentes";
            }
            else
            {
                return "Datos NO equivalentes";
            }
        }
        public string substring_Mid(string txt, string r1, string r2)
        {
            try
            {
                return ObjMTS.substring(txt, Int32.Parse(r1), Int32.Parse(r2));
            }catch(Exception e)
            {
                return "Error";
            }
            
        }
        public string split_Mid(string txt, string ctc)
        {
            return ObjMTS.split(txt, char.Parse(ctc), true);
        }
        public string charAt_Mid(string txt, string chAr)
        {
            return ObjMTS.charAt(txt, Int16.Parse(chAr)).ToString();
        }
        public string startWith_Mid(string txt, string pref)
        {
            return ObjMTS.startWith(txt, pref).ToString();
        }
        public string endWith_Mid(string txt, string suf)
        {
            return ObjMTS.endWith(txt, suf).ToString();
        }
    }
}
