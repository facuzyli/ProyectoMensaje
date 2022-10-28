using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuxiliarDAL
    {

        public void Actualizar(Auxiliar miAuxiliar)
        {

            SqlConnection miConexion = Conexion.obtenerConexion();
            try
            {
                miConexion.Open();
                SqlCommand miComando = new SqlCommand("UPDATE Auxiliar SET AsuntoURG = @AsuntoURG , FechayHoraURG = @FechayHoraURG", miConexion);
                miComando.CommandType = System.Data.CommandType.Text;
                miComando.Parameters.AddWithValue("AsuntoURG", miAuxiliar.AsuntoURG);
                miComando.Parameters.AddWithValue("FechayHoraURG", miAuxiliar.FechayHoraURG);
                miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                miConexion.Close();
            }


        }

    }
}
