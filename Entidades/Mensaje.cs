using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensaje
    {
        public int IdRegistro{ get; set; }

        public string Asunto{ get; set; }

        public string Mensajee { get; set; }

        public string Emisor { get; set; }

        public string Receptor { get; set; }

        public bool Urgencia { get; set; }

        public DateTime FechayHora { get; set; }



    }
}
