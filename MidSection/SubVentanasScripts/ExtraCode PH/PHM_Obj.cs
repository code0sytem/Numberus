using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcesamientoYcomunicacionExterna.subVentanasScript.ParcialHeladeria;
using System.Windows.Forms;

namespace MidSection.SubVentanasScripts.ExtraCode_PH
{
    public class PHM_Obj : ParcialHeladeria_Mid
    {
        private Dictionary<string, int> preciosSabores = new Dictionary<string, int>();
        private Dictionary<string, int> preciosRecipientes = new Dictionary<string, int>();
        private Dictionary<string, int> preciosAdicionales = new Dictionary<string, int>();
        //
        private static List<DataHelados> DHD = new List<DataHelados>();
        private static int[][] AcumulatedTotal = new int[][]
        {
            new int[] {0,0,0,0,0,0},
            new int[] {0,0,0},
            new int[] {0,0,0,0,0,0}
        };
        //
        private static double precioTotal { get; set; }
        private int precioTotalSabores { get; set; }
        private static int[] TotalSabores = { 0, 0, 0, 0, 0, 0 };
        private int precioTotalRecipientes { get; set; }
        private static int[] TotalRecipientes = { 0, 0, 0};
        private int precioTotalAdicionales { get; set; }
        private static int[] TotalAdicionales = { 0, 0, 0, 0, 0, 0 };
        //
        private static int voteNum = -1;
        //
        private static string SuperAux { get; set; }
        //
        public double getPrecioTotal()
        {
            return precioTotal;
        }
        //
        public void format(bool f)
        {
            if (f)
            {
                DHD.Clear();
                voteNum = -1;
                for (int i = 0; i < 6; i++)
                {
                    AcumulatedTotal[0][i] = 0;
                    AcumulatedTotal[2][i] = 0;
                    if (i < 3) AcumulatedTotal[1][i] = 0;
                }
            }
            for(int i = 0; i<6; i++)
            {
                TotalSabores[i] = 0;
                TotalAdicionales[i] = 0;
                if (i < 3) TotalRecipientes[i] = 0;
            }
        }
        //
        public int getVoteNum()
        {
            return voteNum;
        }
        //
        public string getVentasDia()
        {
            StringBuilder salidaBuilder = new StringBuilder();

            salidaBuilder.Append("Total ventas del dia: " + DHD.Count + "\n");
            salidaBuilder.Append("Total ganancias del dia: ");
            salidaBuilder.Append((AcumulatedTotal[0][0] * preciosSabores["vainilla"]) +
                (AcumulatedTotal[0][1] * preciosSabores["chocolate"])+
                (AcumulatedTotal[0][2] * preciosSabores["fresa"])+
                (AcumulatedTotal[0][3] * preciosSabores["limon"])+
                (AcumulatedTotal[0][4] * preciosSabores["chicle"])+
                (AcumulatedTotal[0][5] * preciosSabores["coockies"])+
                (AcumulatedTotal[1][0] * preciosRecipientes["cono"])+
                (AcumulatedTotal[1][1] * preciosRecipientes["basito"])+
                (AcumulatedTotal[1][2] * preciosRecipientes["copa"])+
                (AcumulatedTotal[2][0] * preciosAdicionales["Arequipe"])+
                (AcumulatedTotal[2][1] * preciosAdicionales["Chips"])+
                (AcumulatedTotal[2][2] * preciosAdicionales["Cereales"])+
                (AcumulatedTotal[2][3] * preciosAdicionales["Gomitas"])+
                (AcumulatedTotal[2][4] * preciosAdicionales["Nutella"])+
                (AcumulatedTotal[2][5] * preciosAdicionales["Mani"]));
            salidaBuilder.Append("\n\n");
            salidaBuilder.Append("Total de vainilla vendido: " + AcumulatedTotal[0][0] + " unidades a " +
                (AcumulatedTotal[0][0] * preciosSabores["vainilla"]) + "\n");
            salidaBuilder.Append("Total de chocolate vendido: " + AcumulatedTotal[0][1] + " unidades a " +
                (AcumulatedTotal[0][1] * preciosSabores["chocolate"]) + "\n");
            salidaBuilder.Append("Total de fresas vendido: " + AcumulatedTotal[0][2] + " unidades a " +
                (AcumulatedTotal[0][2] * preciosSabores["fresa"]) + "\n");
            salidaBuilder.Append("Total de limon vendido: " + AcumulatedTotal[0][3] + " unidades a " +
                (AcumulatedTotal[0][3] * preciosSabores["limon"]) + "\n");
            salidaBuilder.Append("Total de chicle vendido: " + AcumulatedTotal[0][4] + " unidades a " +
                (AcumulatedTotal[0][4] * preciosSabores["chicle"]) + "\n");
            salidaBuilder.Append("Total de cookies & cream vendido: " + AcumulatedTotal[0][5] + " unidades a " +
                (AcumulatedTotal[0][5] * preciosSabores["coockies"]) + "\n\n");
            //
            salidaBuilder.Append("Total de conos vendidos: " + AcumulatedTotal[1][0] + " unidades a " +
                (AcumulatedTotal[1][0] * preciosRecipientes["cono"]) + "\n");
            salidaBuilder.Append("Total de basitos vendidos: " + AcumulatedTotal[1][1] + " unidades a " +
                (AcumulatedTotal[1][1] * preciosRecipientes["basito"]) + "\n");
            salidaBuilder.Append("Total de copas vendidas: " + AcumulatedTotal[1][2] + " unidades a " +
                (AcumulatedTotal[1][2] * preciosRecipientes["copa"]) + "\n\n");
            //
            salidaBuilder.Append("Total de arequipe vendido: " + AcumulatedTotal[2][0] + " unidades a " +
                (AcumulatedTotal[2][0] * preciosAdicionales["Arequipe"]) + "\n");
            salidaBuilder.Append("Total de chips vendido: " + AcumulatedTotal[2][1] + " unidades a " +
                (AcumulatedTotal[2][1] * preciosAdicionales["Chips"]) + "\n");
            salidaBuilder.Append("Total de cereales vendido: " + AcumulatedTotal[2][2] + " unidades a " +
                (AcumulatedTotal[2][2] * preciosAdicionales["Cereales"]) + "\n");
            salidaBuilder.Append("Total de gomitas vendidas: " + AcumulatedTotal[2][3] + " unidades a " +
                (AcumulatedTotal[2][3] * preciosAdicionales["Gomitas"]) + "\n");
            salidaBuilder.Append("Total de nutella vendida: " + AcumulatedTotal[2][4] + " unidades a " +
                (AcumulatedTotal[2][4] * preciosAdicionales["Nutella"]) + "\n");
            salidaBuilder.Append("Total de mani vendido: " + AcumulatedTotal[2][5] + " unidades a " +
                (AcumulatedTotal[2][5] * preciosAdicionales["Mani"]) + "\n");

            return salidaBuilder.ToString();
        }
        //
        public PHM_Obj()
        {
            preciosSabores.Clear();
            preciosSabores.Add("vainilla", 700);
            preciosSabores.Add("chocolate", 800);
            preciosSabores.Add("fresa", 820);
            preciosSabores.Add("limon", 900);
            preciosSabores.Add("chicle", 910);
            preciosSabores.Add("coockies", 850);
            //
            preciosRecipientes.Clear();
            preciosRecipientes.Add("cono", 200);
            preciosRecipientes.Add("basito", 150);
            preciosRecipientes.Add("copa", 300);
            //
            preciosAdicionales.Clear();
            preciosAdicionales.Add("Arequipe", 1000);
            preciosAdicionales.Add("Chips", 1300);
            preciosAdicionales.Add("Cereales", 1500);
            preciosAdicionales.Add("Gomitas", 1250);
            preciosAdicionales.Add("Nutella", 2000);
            preciosAdicionales.Add("Mani", 700);
            //
            Random ran = new Random(0);
            if (voteNum == -1) voteNum = ran.Next(0, 3);
        }

        private int sabores()
        {
            precioTotalSabores = 0;
            foreach (object sab_ in getSaboresValue())
            {
                precioTotalSabores += preciosSabores[sab_.ToString()];
                switch (sab_.ToString())
                {
                    case "vainilla": TotalSabores[0]++; SuperAux = TotalSabores[0].ToString()+" "; break;
                    case "chocolate": TotalSabores[1]++; SuperAux += TotalSabores[1].ToString() + " "; break;
                    case "fresa": TotalSabores[2]++; SuperAux += TotalSabores[2].ToString() + " "; break;
                    case "limon": TotalSabores[3]++; SuperAux += TotalSabores[3].ToString() + " "; break;
                    case "chicle": TotalSabores[4]++; SuperAux += TotalSabores[4].ToString() + " "; break;
                    case "coockies": TotalSabores[5]++; SuperAux += TotalSabores[5].ToString() + "\n"; break;
                }
            }
            return precioTotalSabores;
        }

        private int recipientes()
        {
            precioTotalRecipientes = 0;
            foreach (object sab_ in getRecipientesValue())
            {
                precioTotalRecipientes += preciosRecipientes[sab_.ToString()];
                switch (sab_.ToString())
                {
                    case "cono": TotalRecipientes[0]++; SuperAux += TotalRecipientes[0].ToString() + " "; break;
                    case "basito": TotalRecipientes[1]++; SuperAux += TotalRecipientes[1].ToString() + " "; break;
                    case "copa": TotalRecipientes[2]++; SuperAux += TotalRecipientes[2].ToString() + "\n"; break;
                }
            }
            return precioTotalRecipientes;
        }

        private int adicionales()
        {
            precioTotalAdicionales = 0;
            foreach(ArrayList sab in getAdicionalesValue())
            {
                foreach(object sab_ in sab)
                {
                    precioTotalAdicionales += preciosAdicionales[sab_.ToString()];
                    switch (sab_.ToString())
                    {
                        case "Arequipe": TotalAdicionales[0]++; SuperAux += TotalAdicionales[0].ToString() + " "; break;
                        case "Chips": TotalAdicionales[1]++; SuperAux += TotalAdicionales[1].ToString() + " "; break;
                        case "Cereales": TotalAdicionales[2]++; SuperAux += TotalAdicionales[2].ToString() + " "; break;
                        case "Gomitas": TotalAdicionales[3]++; SuperAux += TotalAdicionales[3].ToString() + " "; break;
                        case "Nutella": TotalAdicionales[4]++; SuperAux += TotalAdicionales[4].ToString() + " "; break;
                        case "Mani": TotalAdicionales[5]++; SuperAux += TotalAdicionales[5].ToString() + "-\n"; break;
                    }
                }
            }
            return precioTotalAdicionales;
        }

        public void setPrecioTotal(double aux)
        {
            precioTotal = aux;
        }

        public int calculatePrecioTotal()
        {
            format(false); //borra instancias inecesarias provenientes de los metodos sabores, recipientes y adicionales
            int aux = sabores() + recipientes() + adicionales();
            //MessageBox.Show(SuperAux);
            return aux;
        }

        public void guardarEstadoVentas()
        {
            foreach(DataHelados DHp in DH)
            {
                DHD.Add(DHp);
            }
            for(int i=0; i<6; i++)
            {
                AcumulatedTotal[0][i] += TotalSabores[i];
                AcumulatedTotal[2][i] += TotalAdicionales[i];
                if (i < 3) 
                { 
                    AcumulatedTotal[1][i] += TotalRecipientes[i];
                }
            }
            format(false); //borra instancias inecesarias provenientes de los metodos sabores, recipientes y adicionales
            DH.Clear();
        }
    }
}
