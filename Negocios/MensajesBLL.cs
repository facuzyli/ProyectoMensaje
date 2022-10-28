using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Negocios
{
    public class MensajesBLL
    {
        MensajesDAL miMensajeDAL = new MensajesDAL();
        AuxiliarDAL miAuxiliarDAL = new AuxiliarDAL();


        public void Crear(Mensaje miMensaje)
        {

            using (TransactionScope miTransactionScope = new TransactionScope())
            {

                try
                {
                    miMensajeDAL.Crear(miMensaje);

                    if (!miMensaje.Urgencia)
                    {
                        Auxiliar miAuxiliar = new Auxiliar();
                        miAuxiliar.FechayHoraURG = DateTime.Today;
                        miAuxiliar.AsuntoURG = "URGENTE";
                        miAuxiliarDAL.Actualizar(miAuxiliar);
                    }
                    miTransactionScope.Complete();
                }
                catch (Exception)
                {
                    miTransactionScope.Dispose();
                    throw;
                }
            }

        }


        public List<Mensaje> obtenerTodos()
        {
            try
            {
                return miMensajeDAL.obtenerTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }



}

