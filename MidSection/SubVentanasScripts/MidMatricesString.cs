using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcesamientoYcomunicacionExterna.subVentanasScript;

namespace MidSection.SubVentanasScripts
{
    public class MidMatricesString
    {
        MetodosTipoString MTS = new MetodosTipoString();
        MatricesString a = new MatricesString();
        public bool Mid_Guardar(string[] datos)
        {
            try
            {
                return a.Guardar(datos);
            }catch(Exception e)
            {
                return false;
            }
            
        }
        
        public string[] Mid_Consultar(string[] data)
        {
            string cadena = a.Consultar(data);
            string[] datos = MTS.split(cadena, ' ');
            return datos;
        }
        public string Mid_ImpresionXquincena(string data1, string data2)
        {
            string[] data = { data1, data2 };
            return a.ImpresionXquincena(data);
        }
        public string Mid_ImpresionXmes(string data1, string mes)
        {
            string[] fechasSep = { "15-09-10", "30-09-10" };
            string[] fechasOct = { "15-10-10", "30-10-10" };
            try
            {
                if(mes == "SEPTIEMBRE")
                {
                    return a.ImpresionXmes(data1, fechasSep, mes);
                }
                else
                {
                    return a.ImpresionXmes(data1, fechasOct, mes);
                }
            }
            catch (Exception e)
            {
                return "-1";
            }
        }
        public string Mid_ImpresionXmeses(string data)
        {
            string[] fechas = { "15-09-10", "30-09-10", "15-10-10", "30-10-10" };
            try
            {
                return a.ImpresionXmeses(fechas, data);
            }
            catch (Exception e)
            {
                return "-1";
            }
        }
    }
}
