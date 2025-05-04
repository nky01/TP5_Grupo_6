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
                conexion.mostrarTodasSucursales(gvSucursal);
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            conexion.filtrarSucursal(gvSucursal, txtBusqueda);
            if(gvSucursal.Rows.Count == 0)
            {
                labelError.Text = "La sucursal ingresada no existe.";
            }
            limpiarTextbox();
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            conexion.mostrarTodasSucursales(gvSucursal);
            limpiarTextbox();
        }

        protected void limpiarTextbox()
        {
            txtBusqueda.Text = string.Empty;
        }

    }
}