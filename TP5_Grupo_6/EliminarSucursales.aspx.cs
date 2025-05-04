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
        private Conexion conexion;
        string consultasql;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();
            string idsucursal = txtBusqueda.Text;
            consultasql = "DELETE FROM Sucursal WHERE Id_Sucursal = " + idsucursal;


            conexion.Conectar();
            SqlCommand comando = new SqlCommand(consultasql, conexion.Conectar());
            int filasAfectadas = comando.ExecuteNonQuery();
            if (filasAfectadas == 0)
            {
                lblInexistente.Text = "ID de sucursal inexistente.";
            }
            else
            {
                exitolbl.Text = "Sucursal eliminada con éxito.";
            }
        }
    }
}