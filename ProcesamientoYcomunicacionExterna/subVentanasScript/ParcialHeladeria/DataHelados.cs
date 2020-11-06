using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoYcomunicacionExterna.subVentanasScript.ParcialHeladeria
{
    public class DataHelados : DataPrincipal
    {
        private ArrayList AdicionalesInfo = new ArrayList();
        private string Sabor { get; set; }
        private string Recipiente { get; set; }
        private int NumeroInstancia { get; set; }
        //int aux;

        public DataHelados() : base() //metodo unico
        {
            //AdicionalesInfo.Clear();
        }

        public void NIUpdate(int i)
        {
            NumeroInstancia = i;
        }

        public string GetSabor()
        {
            return Sabor;
        }
        public string GetRecipiente()
        {
            return Recipiente;
        }
        public ArrayList GetAdicional()
        {
            return AdicionalesInfo;
        }

        public void defObj(string n, string t, string c, string d, string ce)
        {
            resetearObj();
            definirObj(n, t, c, d, ce);
        }

        public void asignarHeladosInfo(string sabor, string recip)
        {
            this.Sabor = sabor;
            this.Recipiente = recip;
        }

        public void asignarAdicionalesInfo(ArrayList AI)
        {
            AdicionalesInfo.Clear();
            foreach(object AIn in AI)
            {
                AdicionalesInfo.Add(AIn);
            }
        }

        public void setNI(int i)
        {
            NumeroInstancia = i;
        }

        public int getNI()
        {
            return NumeroInstancia;
        }

        public string ImprimirTXT()
        {
            string salida="";
            salida += retornarDP();

            salida += "Sabor: " + Sabor + "\n" + "Recipiente: " + Recipiente + "\n" + "Adicionales: ";
            int i = 0;
            foreach(object Adit in AdicionalesInfo)
            {
                salida += Adit.ToString() + ", ";
                if (i == 2)
                {
                    salida += "\n";
                }
            }
            salida += "\nNumero de instancia: " + (NumeroInstancia+1);

            return salida;
        }
    }
}
