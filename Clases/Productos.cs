using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class Productos
    {
        public int IdProduct { get; set; }
        public string NombreProduct { get; set; }
        public int PrecioUnit { get; set; }
        public int Cantidad { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }

    }
}