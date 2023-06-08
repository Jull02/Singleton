using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD.Pages
{
	public class Singleton
	{
		private readonly static SqlConnection _instance = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

		public static SqlConnection Instance
		{
			get
			{
				return _instance;
			}
		}

		private Singleton()
		{
		}
	}
}