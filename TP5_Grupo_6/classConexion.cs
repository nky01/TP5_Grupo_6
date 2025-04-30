using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TP5_Grupo_6
{
	public class classConexion
	{
		private const string cadenaconexion =  "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales;Integrated Security = True";
		int filaAfectada;
		public int SucursalAltaBaja (string consultaSQL)
		{
			return filaAfectada;
		}
    }
}