using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcesamientoYcomunicacionExterna.subVentanasScript.archivos_de_textos;

namespace MidSection.SubVentanasScripts
{
    public class FormatTexts_Mid
    {
        FormatTexts FT = new FormatTexts();
        
        public string Leer(string file)
        {
            int aux = FT.Lectura(file).Count;
            string cadena = "";
            for (int i = 0; i < aux; i++)
            {
                cadena += FT.Lectura(file)[i].ToString();
            }
            return cadena;
        }
        public string[] BuscarArchivos()
        {
            return FT.DirectorySearch();
        }
        public int ContadorCaracteres_Mid(string t)
        {
            return FT.ContadorCaracteres(t);
        }
        public int ContadorNumerico_Mid(string t)
        {
            return FT.ContadorNumerico(t);
        }
        public int ContadorLetras_Mid(string t)
        {
            return FT.ContadorLetras(t);
        }
    }
}
