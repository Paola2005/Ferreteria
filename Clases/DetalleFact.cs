using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class DetalleFact
    {
        public int IdDetalle { get; set; }
        public int NroFact { get; set; }
        public int IdProduct { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }
    }
}