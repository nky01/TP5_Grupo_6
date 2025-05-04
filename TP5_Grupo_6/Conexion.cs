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

            if(idSucursal.Text == string.Empty)
            {
                mostrarTodasSucursales(grillaSucursales);
                return;
            }

            int id= Convert.ToInt32(idSucursal.Text);


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

        public void mostrarTodasSucursales(GridView gvSucursal)
        {
            string filtro = "SELECT Id_Sucursal, NombreSucursal, DescripcionSucursal, DescripcionProvincia, DireccionSucursal from Sucursal inner join Provincia on Id_ProvinciaSucursal = Id_Provincia";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(filtro, conexion);
                SqlDataReader reader =comando.ExecuteReader();
                if (reader != null)
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    reader.Close();

                    gvSucursal.DataSource = tabla;
                    gvSucursal.DataBind();
                }
            }
        }

        public int eliminarSucursal(string IdSucursal)
        {
            if(int.TryParse(IdSucursal, out int Id_Sucursal))
            {

                string eliminar = "DELETE FROM Sucursal WHERE Id_Sucursal = @Id_Sucursal";
                
                using(SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(eliminar, conexion);
                    comando.Parameters.AddWithValue("@Id_Sucursal", Id_Sucursal);
                    return comando.ExecuteNonQuery();
                }
            }
            
            return 0;
        }

    }
}