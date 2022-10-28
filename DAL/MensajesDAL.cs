using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MensajesDAL
    {
        public void Crear(Mensaje pMensaje)
        {
            SqlConnection miConexion = Conexion.obtenerConexion();
            try
            {

                miConexion.Open();
                SqlCommand miComando = new SqlCommand("INSERT INTO Mensaje (Asunto, Mensajee, Emisor, Receptor, Urgencia, FechayHora) VALUES (@Asunto, @Mensajee, @Emisor, @Receptor, @Urgencia, @FechayHora )", miConexion);

                miComando.CommandType = System.Data.CommandType.Text;

                miComando.Parameters.AddWithValue("Asunto", pMensaje.Asunto);
                miComando.Parameters.AddWithValue("Mensajee", pMensaje.Mensajee);
                miComando.Parameters.AddWithValue("Emisor", pMensaje.Emisor);
                miComando.Parameters.AddWithValue("Receptor", pMensaje.Receptor);
                miComando.Parameters.AddWithValue("Urgencia", pMensaje.Urgencia);
                miComando.Parameters.AddWithValue("FechayHora", pMensaje.FechayHora);

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
        public List<Mensaje> obtenerTodos()
        {

            SqlConnection miConexion = Conexion.obtenerConexion();
            miConexion.Open();
            SqlCommand miComando = new SqlCommand("SELECT * FROM Mensaje", miConexion);
            miComando.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter miAdapter = new SqlDataAdapter();
            miAdapter.SelectCommand = miComando;
            DataSet miDataSet = new DataSet();
            miAdapter.Fill(miDataSet, "Mensaje");

            var bebidas = from row in miDataSet.Tables[0].AsEnumerable()
                          select new Mensaje()
                          {
                              IdRegistro = row.Field<int>("IdRegistro"),
                              Asunto = row.Field<string>("Asunto"),
                              Mensajee = row.Field<string>("Mensajee"),
                              Emisor = row.Field<string>("Emisor"),
                              Receptor = row.Field<string>("Receptor"),
                              Urgencia = row.Field<bool>("Urgencia"),
                              FechayHora = row.Field<DateTime>("FechayHora")
                          };
            return bebidas.ToList();

        }
    }
}
