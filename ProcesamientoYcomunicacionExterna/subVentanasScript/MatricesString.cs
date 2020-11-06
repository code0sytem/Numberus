using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ProcesamientoYcomunicacionExterna.subVentanasScript
{
    public class MatricesString
    {
        MetodosTipoString MTS = new MetodosTipoString();
        private int FileZize(string ruta)
        {
            StreamReader file = new StreamReader(ruta);
            string aux;
            int i = 0;
            do
            {
                aux = file.ReadLine();
                i++;
            } while (aux != null);
            file.Close();
            return i;
        }
        public bool Guardar(string[] datos)
        {
            string rutaA = "Datos";
            if (!Directory.Exists(rutaA))
            {
                Directory.CreateDirectory(rutaA);
            }
            //string fech = datos[3];
            //fech = MTS.split(fech, '-', false);
            string rutaB = "BaseDatos";
            //string rutaAB = rutaA + "/" + rutaB + ".txt";
            byte[] rutaBC = Encoding.UTF32.GetBytes(rutaB);
            string rutaC = rutaA + "/" + BitConverter.ToString(rutaBC) + ".txt";
            //
            if (!File.Exists(rutaC))
            {
                //si el archivo no existe
                StreamWriter archivoEsc = new StreamWriter(rutaC);
                string dato = "";
                for (int i = 0; i < 11; i++)
                {
                    dato += datos[i] + " ";
                }
                archivoEsc.Write(dato);
                archivoEsc.Close();
                return true;
            }
            else
            {
                int FileZizeVar = FileZize(rutaC);
                StreamReader archivoRead = new StreamReader(rutaC);
                string[] PreData = new string[FileZizeVar];
                for(int i = 0; i < FileZizeVar; i++)
                {
                    PreData[i] = archivoRead.ReadLine();
                }
                archivoRead.Close();
                //
                string dato = "";
                for (int i = 0; i < 11; i++)
                {
                    dato += datos[i] + " ";
                }
                //
                StreamWriter archivoEsc = new StreamWriter(rutaC);
                for (int i = 0; i < FileZizeVar; i++)
                {
                    if (i == FileZizeVar - 1)
                    {
                        archivoEsc.Write(PreData[i]);
                    }
                    else
                    {
                        archivoEsc.Write(PreData[i] + "\n");
                    }
                }
                //
                archivoEsc.Write(dato);
                archivoEsc.Close();
                return true;
            }
            
        }
        public string Consultar(string[] buscar)
        {
            string cadena = "";
            string nombre = "BaseDatos";
            byte[] ByteNombre = Encoding.UTF32.GetBytes(nombre);
            string EncNombre = BitConverter.ToString(ByteNombre);
            string rutaA = "Datos";
            if (Directory.Exists(rutaA))
            {
                string rutaB = rutaA + "/" + EncNombre + ".txt";
                bool ok = false;
                if (File.Exists(rutaB))
                {
                    int tamaño = FileZize(rutaB);
                    StreamReader arch = new StreamReader(rutaB);
                    string[] data = new string[11];
                    //
                    cadena = arch.ReadLine();
                    //
                    for(int i=0; i<tamaño-1; i++)
                    {
                        data = cadena.Split(' ');
                        if (data[0] == buscar[0] && data[3] == buscar[1])
                        {
                            arch.Close();
                            ok = true;
                            break;
                        }
                        cadena = arch.ReadLine();
                    }
                    if (!ok)
                    {
                        arch.Close();
                        return "dato_no_encontrado";
                    }
                }
                else
                {
                    return "numero_de_identificacion_o_fecha_de_quncena_incorrecta ";
                }
            }
            else
            {
                return "directorio_no_encontrado ";
            }
            return cadena;
        }
        public string ImpresionXquincena(string[] conVar)
        {
            Excel.Application ExcelApp = new Excel.Application();
            string cadena = Consultar(conVar);
            //
            string[] datos = cadena.Split(char.Parse(" "));
            //
            if (ExcelApp == null)
            {
                //MessageBox.Show("Excel is not properly installed!!");
                return "-2";
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            //
            xlWorkBook = ExcelApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //bucle de nombre de columnas y sus respectivas variables
            string[] ColumnName = { "cedula", "apellido", "nombre", "fecha",
            "dept", "sueldo base", "desc EPS", "desc Pension",
            "desc anticipo", "desc prestamos", "salario Neto"};
            for(int i = 1; i < 12; i++)
            {
                xlWorkSheet.Cells[1, i] = ColumnName[i - 1];
            }
            //
            for (int i = 0; i < 11; i++)
            {
                xlWorkSheet.Cells[2, i+1] = datos[i];
            }

            xlWorkBook.SaveAs(conVar[0] + conVar[1] + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Save();
            xlWorkBook.Close(true, misValue, misValue);
            ExcelApp.Quit();
            //
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(ExcelApp);
            return "Excel exportado en carpeta Documents";
        }
        public string ImpresionXmes(string conVar, string[] fechas, string mes)
        {
            Excel.Application ExcelApp = new Excel.Application(); 

            string[] buscar = { conVar, fechas[0] };
            string cadena = Consultar(buscar);
            //
            string[] buscar1 = { conVar, fechas[1] };
            string cadena1 = Consultar(buscar1);
            //
            string[] datos = cadena.Split(char.Parse(" "));
            string[] datos1 = cadena1.Split(char.Parse(" "));
            //
            if (ExcelApp == null /*|| Directory.Exists(direccion)*/)
            {
                return "-2";
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            //
            xlWorkBook = ExcelApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //bucle de nombre de columnas y sus respectivas variables
            string[] ColumnName = { "cedula", "apellido", "nombre", "fecha",
            "dept", "sueldo base", "desc EPS", "desc Pension",
            "desc anticipo", "desc prestamos", "salario Neto"};
            for (int i = 1; i < 12; i++)
            {
                xlWorkSheet.Cells[1, i] = ColumnName[i - 1];
            }
            //bucle de fila
            for (int i = 0; i < 11; i++)
            {
                xlWorkSheet.Cells[2, i + 1] = datos[i];
            }
            //
            for (int i = 0; i < 11; i++)
            {
                xlWorkSheet.Cells[3, i + 1] = datos1[i];
            }
            //bucle de suma
            for (int i = 0; i < 11; i++)
            {
                if (i >= 5)
                {
                    xlWorkSheet.Cells[4, i + 1] = (int.Parse(datos[i]) + 
                        int.Parse(datos1[i])).ToString();
                }else if (i == 3)
                {
                    xlWorkSheet.Cells[4, i + 1] = mes;
                }
                else
                {
                    xlWorkSheet.Cells[4, i + 1] = datos[i];
                }
            }

            xlWorkBook.SaveAs(conVar + " " + mes + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //
            xlWorkBook.Close(true, misValue, misValue);
            ExcelApp.Quit();
            //
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(ExcelApp);
            return "Excel exportado en carpeta Documents";
        }
        public string ImpresionXmeses(string[] fechas, string conVar)
        {
            Excel.Application ExcelApp = new Excel.Application();
            //
            string[] buscar = { conVar, fechas[0] };
            string cadena = Consultar(buscar);
            //
            string[] buscar1 = { conVar, fechas[1] };
            string cadena1 = Consultar(buscar1);
            //
            string[] buscar2 = { conVar, fechas[2] };
            string cadena2 = Consultar(buscar2);
            //
            string[] buscar3 = { conVar, fechas[3] };
            string cadena3 = Consultar(buscar3);
            //
            string[] datos = cadena.Split(char.Parse(" "));
            string[] datos1 = cadena1.Split(char.Parse(" "));
            string[] datos2 = cadena2.Split(char.Parse(" "));
            string[] datos3 = cadena3.Split(char.Parse(" "));
            //
            if (ExcelApp == null)
            {
                return "-2";
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            //
            xlWorkBook = ExcelApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //bucle de nombre de columnas y sus respectivas variables
            string[] ColumnName = { "cedula", "apellido", "nombre", "fecha",
            "dept", "sueldo base", "desc EPS", "desc Pension",
            "desc anticipo", "desc prestamos", "salario Neto"};
            for (int i = 1; i < 12; i++)
            {
                xlWorkSheet.Cells[1, i] = ColumnName[i - 1];
            }
            //bucle de fila
            for (int i = 0; i < 11; i++)
            {
                if (i >= 5)
                {
                    xlWorkSheet.Cells[2, i + 1] = (int.Parse(datos[i]) +
                        int.Parse(datos1[i])).ToString();
                }
                else if (i == 3)
                {
                    xlWorkSheet.Cells[2, i + 1] = "SEPTIEMBRE";
                }
                else
                {
                    xlWorkSheet.Cells[2, i + 1] = datos[i];
                }
            }
            //
            for (int i = 0; i < 11; i++)
            {
                if (i >= 5)
                {
                    xlWorkSheet.Cells[3, i + 1] = (int.Parse(datos2[i]) +
                        int.Parse(datos3[i])).ToString();
                }
                else if (i == 3)
                {
                    xlWorkSheet.Cells[3, i + 1] = "OCTUBRE";
                }
                else
                {
                    xlWorkSheet.Cells[3, i + 1] = datos[i];
                }
            }
            //bucle de suma
            for (int i = 0; i < 11; i++)
            {
                if (i >= 5)
                {
                    xlWorkSheet.Cells[4, i + 1] = ((int.Parse(datos2[i]) + int.Parse(datos3[i])) +
                        (int.Parse(datos[i]) + int.Parse(datos1[i]))).ToString();
                }
                else if (i == 3)
                {
                    xlWorkSheet.Cells[4, i + 1] = "SEPT y OCT";
                }
                else
                {
                    xlWorkSheet.Cells[4, i + 1] = datos2[i];
                }
            }

            xlWorkBook.SaveAs(conVar + " " + "SEPT y OCT" + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //
            xlWorkBook.Close(true, misValue, misValue);
            ExcelApp.Quit();
            //
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(ExcelApp);
            return "Excel exportado en carpeta Documents";
        }
    }
}
