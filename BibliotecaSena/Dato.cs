using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaSena
{
    class Dato
    {
        public SqlDataAdapter ActualizarDatos()
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Consultar", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            return adaptador;
        }

        public DataSet mostrarEditorial()
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_MostrarEdit", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet daSet = new DataSet();
            adapter.Fill(daSet, "Editorial");
            conexion.Close();
            return daSet;
        }

        public SqlDataAdapter Actualizar()
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_MostrarLibro", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            return adapter;
        }
        public DataSet mostrarLibros()
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_MostrarLibro", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet daset = new DataSet();
            adapter.Fill(daset, "Libros");
            conexion.Close();
            return daset;
        }

        public DataSet mostrarInicial(string inicial)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Inicial", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@Pincial", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = inicial;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adaptador.Fill(data, "Libros");
            conexion.Close();
            return data;
        }

        public DataSet mostrarNombre(ref ComboBox cbnombre)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_CNombre", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cbnombre.Items.Add(leer["NomEdit"]).ToString();
            }
            DataSet set = new DataSet();
            leer.Close();
            return set;
        }
      
             public DataSet combo(string editorial)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            DataSet daset = new DataSet();
            SqlCommand comando = new SqlCommand("pa_Com", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = editorial;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(daset, "Libros");
            conexion.Close();
            return daset;
        }
            public DataSet comboNombre(string editorial)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            DataSet daset = new DataSet();
            if (editorial == "McGraw-Hill")
            {
                SqlCommand comando = new SqlCommand("pa_McGrawH", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 1;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Libros");
                conexion.Close();

            }
            else if (editorial == "Prentice Hall")
            {
                SqlCommand comando = new SqlCommand("pa_PrenticeH", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 2;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Libros");
                conexion.Close();

            }
            else if (editorial == "Kimpres")
            {
                SqlCommand comando = new SqlCommand("pa_Kimpres", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 3;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Libros");
                conexion.Close();

            }
            else if (editorial == "Eni")
            {
                SqlCommand comando = new SqlCommand("pa_Eni", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 4;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Libros");
                conexion.Close();

            }
            return daset;
        }

        public DataSet ascendente(string ascendente)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            DataSet daSet = new DataSet();
            if (ascendente == "NomLibro")
            {
                SqlCommand comando = new SqlCommand("pa_NomLasc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Libros");
                conexion.Close();

            }
            else if (ascendente == "CodLibro")
            {
                SqlCommand comando = new SqlCommand("pa_Codlasc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Libros");
                conexion.Close();

            }
            else if (ascendente == "CodEdit")
            {
                SqlCommand comando = new SqlCommand("pa_CodEditasc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Libros");
                conexion.Close();
            }
                return daSet;


        }
        public DataSet descendente(string descendente)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            DataSet daSet = new DataSet();
            if (descendente == "CodLibro")
            {
                SqlCommand comando = new SqlCommand("pa_Codldsc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Libros");
                conexion.Close();

            }
            else if (descendente == "NomLibro")
            {
                SqlCommand comando = new SqlCommand("pa_NomLibrodsc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Libros");
                conexion.Close();

            }
            else if (descendente == "CodEdit")
            {
                SqlCommand comando = new SqlCommand("pa_CodEditdsc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Libros");
                conexion.Close();
            }
            return daSet;

        }
    }
}
