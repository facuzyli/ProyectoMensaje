using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {
        public static SqlConnection obtenerConexion()
        {

            return new SqlConnection(ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString);

        }
    }
}
