using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProcesamientoYcomunicacionExterna.subVentanasScript.archivos_de_textos
{
    public class FormatTexts
    {
        ArrayList Parrafo = new ArrayList();
        ArrayList error = new ArrayList();
        public ArrayList Lectura(string ru)
        {
            Parrafo.Clear();
            string rut = "C:/Users/jarvys perez/source/repos/Numberus/ProcesamientoYcomunicacionExterna/subVentanasScript/archivos de textos/" + ru;
            if (File.Exists(rut))
            {
                int LineaCount = 0, ParrafoCount=0;
                StreamReader file = new StreamReader(rut);
                Parrafo.Add("");
                string[] linea = new string[2];
                while ((linea[0]=file.ReadLine()) != null)
                {
                    if (linea[0] == "")
                    {
                        Parrafo.Add(linea[1] + "\n");
                        linea[1] = null;
                        ParrafoCount++;
                    }
                    else
                    {
                        linea[1] += linea[0] + "\n";
                    }
                    LineaCount++;
                }
                Parrafo.Add(linea[1] + "\n");
                file.Close();
                return Parrafo;
            }
            else
            {
                error.Add("-1");
                return error;
            }
            
        }
        public string[] DirectorySearch()
        {
            DirectoryInfo a = new DirectoryInfo("C:/Users/jarvys perez/source/repos/Numberus/ProcesamientoYcomunicacionExterna/subVentanasScript/archivos de textos");
            FileInfo[] files = a.GetFiles();
            ArrayList SubSalida = new ArrayList();

            int N_Archivos = 0;
            foreach (FileInfo aux in files)
            {
                if (aux.Extension == ".txt") 
                {
                    SubSalida.Add(aux.Name);
                    N_Archivos++;
                }
            }
            string[] salida = new string[N_Archivos];
            for (int i= 0; i<N_Archivos; i++)
            {
                salida[i] = SubSalida[i].ToString();
            }
            return salida;
        }
        public int ContadorCaracteres(string txt)
        {
            int count = 0;
            foreach (char c in txt)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
        public int ContadorNumerico(string txt)
        {
            int count = 0;
            foreach (char d in txt)
            {
                if (char.IsNumber(d))
                {
                    count++;
                }
            }
            return count;
        }
        public int ContadorLetras(string txt)
        {
            int palabras = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if ((txt[i] == ' ' || txt[i] == '.') && !char.IsNumber(txt[i-1]))
                {
                    palabras++;
                }
            }
            return palabras;
        }
    }
}
