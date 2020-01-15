using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSena
{
    class ConexionBaseDatos
    {
        private static SqlConnection conexion;

        private ConexionBaseDatos()
        {

        }

        public static SqlConnection obtenerConexion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(Properties.Settings.Default.Valor);
                conexion.Open();
            }
            return conexion;
        }
    }
}
