using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcesamientoYcomunicacionExterna.subVentanasScript.ParcialHeladeria;
using System.Windows.Forms;

namespace MidSection.SubVentanasScripts
{
    public class ParcialHeladeria_Mid
    {
        protected static List<DataHelados> DH = new List<DataHelados>();
        string[] DC = new string[5];
        public void recepcionDatosClientes(string n, string t, string c, string d, string ce)
        {
            DC[0] = n;
            DC[1] = t;
            DC[2] = c;
            DC[3] = d;
            DC[4] = ce;
        }

        protected ArrayList getSaboresValue()
        {
            ArrayList a = new ArrayList();
            foreach(DataHelados DHp in DH)
            {
                a.Add(DHp.GetSabor());
            }
            return a;
        }
        protected ArrayList getRecipientesValue()
        {
            ArrayList a = new ArrayList();
            foreach(DataHelados DHp in DH)
            {
                a.Add(DHp.GetRecipiente());
            }
            return a;
        }
        protected ArrayList getAdicionalesValue()
        {
            ArrayList a = new ArrayList();
            foreach(DataHelados DHp in DH)
            {
                a.Add(DHp.GetAdicional());
            }
            return a;
        }

        public void recepcionDatosSabor(string sabor, string recip, ArrayList adic, int i)
        {
            //MessageBox.Show("ad");
            DataHelados DHm = new DataHelados();
            //
            DHm.defObj(DC[0], DC[1], DC[2], DC[3], DC[4]);
            DHm.asignarHeladosInfo(sabor, recip);
            DHm.asignarAdicionalesInfo(adic);
            DHm.setNI(i);
            //
            if (!(DH.Count() == 0))
            {
                foreach(DataHelados DHp in DH)
                {
                    if (DHp.getNI() == i)
                    {
                        DH.RemoveAt(i);
                        DHm.setNI(DH.Count());
                        DH.Add(DHm);
                        //MessageBox.Show(DH.IndexOf(DHm).ToString() + "rem");
                        break;
                    }else if(DH.Count()-1 < i)
                    {
                        DHm.setNI(DH.Count());
                        DH.Add(DHm);
                        //MessageBox.Show(DH.IndexOf(DHm).ToString()+"noRem");
                        break;
                    }
                }
            }
            else
            {
                //MessageBox.Show("setni: " + DH.Count().ToString());
                DHm.setNI(DH.Count());
                DH.Add(DHm);
                //MessageBox.Show(DH.IndexOf(DHm).ToString());
            }
            //
            int iS = 0;
            foreach(DataHelados x in DH)
            {
                //MessageBox.Show("N " + iS);
                DH.ElementAt<DataHelados>(iS).NIUpdate(iS);
                iS++;
            }
            //
            DHm = null;
        }
        public void recepcionDatosSabor(string sabor, string recip, int i)
        {
            //MessageBox.Show("sad");
            DataHelados DHm = new DataHelados();
            //
            DHm.defObj(DC[0], DC[1], DC[2], DC[3], DC[4]);
            DHm.asignarHeladosInfo(sabor, recip);
            DHm.setNI(i);
            //
            if (!(DH.Count() == 0))
            {
                foreach (DataHelados DHp in DH)
                {
                    if (DHp.getNI() == i)
                    {
                        DH.RemoveAt(i);
                        DHm.setNI(DH.Count());
                        DH.Add(DHm);
                        //MessageBox.Show(DH.IndexOf(DHm).ToString() + "rem");
                        break;
                    }
                    else if (DH.Count() - 1 < i)
                    {
                        DHm.setNI(DH.Count());
                        DH.Add(DHm);
                        //MessageBox.Show(DH.IndexOf(DHm).ToString() + "noRem");
                        break;
                    }
                }
            }
            else
            {
                DHm.setNI(DH.Count());
                DH.Add(DHm);
                //MessageBox.Show(DH.IndexOf(DHm).ToString());
            }
            //
            DHm = null;
        }

        public string Imprimir(int i)
        {
            try
            {
                return DH.ElementAt<DataHelados>(i).ImprimirTXT();
            }
            catch (Exception e)
            {
                return "Esta asignacion, aun no existe";
            }
            
        }
    }
}
