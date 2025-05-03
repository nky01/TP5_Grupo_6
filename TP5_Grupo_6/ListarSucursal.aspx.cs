using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP5_Grupo_6
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        string consultasql;
        private Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarSucursales();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            conexion.filtrarSucursal(gvSucursal, txtBusqueda);
            limpiarTextbox();
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mostrarSucursales();
            limpiarTextbox();
        }

        protected void mostrarSucursales()
        {
            consultasql = "SELECT Id_Sucursal, NombreSucursal, DescripcionSucursal, DescripcionProvincia, DireccionSucursal from Sucursal inner join Provincia on Id_ProvinciaSucursal = Id_Provincia";
            conexion.Conectar();

            SqlDataReader reader = conexion.EjecutarConsulta(consultasql);
            if (reader != null)
            {
                DataTable tabla = new DataTable();
                tabla.Load(reader);
                reader.Close();
                conexion.Cerrar();

                gvSucursal.DataSource = tabla;
                gvSucursal.DataBind();
            }

            conexion.Cerrar();
        }

        protected void limpiarTextbox()
        {
            txtBusqueda.Text = string.Empty;
        }

    }
}