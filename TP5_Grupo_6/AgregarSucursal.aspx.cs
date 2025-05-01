using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP5_Grupo_6
{
	public partial class tp05EjercicioA : System.Web.UI.Page
	{
		string consultaSQL;
		int filaAfectada;
		Conexion conexion = new Conexion();
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack) { 
                
                consultaSQL = "SELECT * FROM Provincia";

                conexion = new Conexion();
                conexion.Conectar();

                SqlDataReader reader = conexion.EjecutarConsulta(consultaSQL);
                if (reader != null)
                 {
                ddlProvincia.Items.Clear();
                ddlProvincia.Items.Add(new ListItem("-- Seleccione una provincia --", "0"));

                while (reader.Read())
                {
                    string nombreprovincia = reader["DescripcionProvincia"].ToString();
                    string idProvincia = reader["Id_Provincia"].ToString();
                    ddlProvincia.Items.Add(new ListItem(nombreprovincia, idProvincia));
                }
                reader.Close();
                 }

            conexion.Cerrar(); 
            }
           
        }

        protected void buttonAceptar_Click(object sender, EventArgs e)
        {
			consultaSQL = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES ('" + txtNombre.Text + "', '" + txtDescripcion.Text + "'," + ddlProvincia.SelectedValue + ",'" + txtDireccion.Text + "')";
            conexion.agregarSucursal(consultaSQL);
        }
    }
}