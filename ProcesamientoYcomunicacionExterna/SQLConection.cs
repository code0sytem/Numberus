using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProcesamientoYcomunicacionExterna
{
    public class SQLConection
    {
        SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = NumberusDatabase; Integrated Security = True");

        public SqlConnection conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection desconectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
