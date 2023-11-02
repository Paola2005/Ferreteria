using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class Factura
    {
        public int NroFact { get; set; }
        public string NombreFact { get; set; }
        public DateOnly Fecha { get; set; }
        public int IdCliente { get; set; }
        public double TotalFact { get; set; }
    }
}