using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP5_Grupo_6
{
    public class Conexion
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
        private SqlConnection sqlConnection;

        public SqlConnection Conectar()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(cadenaConexion);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            return sqlConnection;
        }

        public void Cerrar()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlDataReader EjecutarConsulta(string consultaSQL)
        {
            SqlCommand comando = new SqlCommand(consultaSQL, Conectar());

            if (consultaSQL.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
            {
                return comando.ExecuteReader();
            }
            else
            {
                comando.ExecuteNonQuery();
                return null;
            }
        }
        public int SucursalAltaBaja(string consultaSQL)
        {
            SqlCommand comando = new SqlCommand(consultaSQL, Conectar());
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }

        public int agregarSucursal(string consultaSQL)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(consultaSQL,conexion);
                return comando.ExecuteNonQuery();
            }
        }
    }
}