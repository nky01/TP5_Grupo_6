using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;


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

        public void filtrarSucursal(GridView grillaSucursales, TextBox idSucursal)
        {
            string filtrar = "SELECT s.Id_Sucursal, s.NombreSucursal, s.DescripcionSucursal, p.DescripcionProvincia, s.DireccionSucursal " +
                             "FROM Sucursal s " +
                             "INNER JOIN Provincia p ON s.Id_ProvinciaSucursal = p.Id_Provincia " +
                             "WHERE s.Id_Sucursal = @Id_Sucursal";
            int id = Convert.ToInt32(idSucursal.Text);

            using(SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(filtrar, conexion);
                comando.Parameters.AddWithValue("@Id_Sucursal", id);

                SqlDataReader sucursalReader = comando.ExecuteReader();

                DataTable tabla = new DataTable();
                tabla.Load(sucursalReader);

                grillaSucursales.DataSource = tabla;
                grillaSucursales.DataBind();

                sucursalReader.Close();

                
            }
        }
    }
}