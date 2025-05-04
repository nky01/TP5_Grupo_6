using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_Grupo_6
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        private Conexion conexion = new Conexion();
        string consultasql;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (conexion.eliminarSucursal(txtBusqueda.Text) == 0)
            {
                txtBusqueda.Text = "";
                lblInexistente.Text = "ID de sucursal inexistente.";
                exitolbl.Text = "";
            }
            else
            {
                txtBusqueda.Text = "";
                exitolbl.Text = "Sucursal eliminada con éxito.";
                lblInexistente.Text = "";
            }
        }
    }
}