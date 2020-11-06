using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoYcomunicacionExterna.subVentanasScript.ParcialHeladeria
{
    public class DataPrincipal
    {
        protected ArrayList DatosClientes = new ArrayList();

        
        protected DataPrincipal()
        {

        }

        protected void definirObj(string n, string t, string c, string d, string ce)
        {
            DatosClientes.Add(n);
            DatosClientes.Add(t);
            DatosClientes.Add(c);
            DatosClientes.Add(d);
            DatosClientes.Add(ce);
        }
        protected void resetearObj()
        {
            DatosClientes.Clear();
        }
        protected string retornarDP()
        {
            string salida = "";
            string[] df = { "Nombre: ", "Telefono: ", "Correo: ", "Direccion: ", "Cedula: " };
            int i = 0;
            foreach(object Dato in DatosClientes)
            {
                salida += df[i] + Dato.ToString() + "\n";
                i++;
            }

            return salida;
        }
    }
}
