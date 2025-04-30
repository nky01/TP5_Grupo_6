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
		classConexion conexion = new classConexion();
		protected void Page_Load(object sender, EventArgs e)
		{
		
		}

        protected void buttonAceptar_Click(object sender, EventArgs e)
        {
			consultaSQL = "INSERT Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES ('" + textboxNombre.Text + "', '" + textboxDescripcion.Text + "'," + ddlProvincia.SelectedValue + ",'" + textboxDireccion.Text + "')";
			filaAfectada = conexion.SucursalAltaBaja(consultaSQL);

        }
    }
}