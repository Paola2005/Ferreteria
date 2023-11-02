using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class Linq
    {       
        IList<Clientes>_Cliente=new List<Clientes>(){
            new Clientes(){IdClient=1,NombreClient="Pepito",Email="Pepito@gamil.com"},
            new Clientes(){IdClient=2,NombreClient="Jhoan",Email="Jhoan@gamil.com"},
            new Clientes(){IdClient=3,NombreClient="Mariana",Email="Mariana@gamil.com"}
        };
        List<Productos>_Productos = new(){
            new Productos(){IdProduct=1,NombreProduct="Tornillos",PrecioUnit=1000,Cantidad=20,StockMin=100,StockMax=200},
            new Productos(){IdProduct=2,NombreProduct="Cables",PrecioUnit=2000,Cantidad=800,StockMin=100,StockMax=800},
            new Productos(){IdProduct=3,NombreProduct="Tuercas",PrecioUnit=1000,Cantidad=60,StockMin=100,StockMax=900},
            new Productos(){IdProduct=4,NombreProduct="Bombillos",PrecioUnit=3000,Cantidad=400,StockMin=100,StockMax=400},
            new Productos(){IdProduct=5,NombreProduct="Martillos",PrecioUnit=9000,Cantidad=10,StockMin=100,StockMax=500},
        };
        List<Factura>_Factura=new(){
            new Factura(){NroFact=11,NombreFact="Factura1",Fecha=new DateOnly(2023,01,13),IdCliente=1,TotalFact=1000000},
            new Factura(){NroFact=12,NombreFact="Factura2",Fecha=new DateOnly(2023,05,13),IdCliente=3,TotalFact=6000000},
            new Factura(){NroFact=13,NombreFact="Factura3",Fecha=new DateOnly(2023,02,13),IdCliente=5,TotalFact=8000000},
            new Factura(){NroFact=14,NombreFact="Factura5",Fecha=new DateOnly(2023,01,03),IdCliente=2,TotalFact=21000000}
        };
        List<DetalleFact>_Detalle=new(){
            new DetalleFact(){IdDetalle=1}
        };

        public void First(){
            _Productos.ForEach(x=>Console.WriteLine($"Id={x.IdProduct}, Nombre={x.NombreProduct}, PrecioUnidad={x.PrecioUnit}, Cantidad={x.Cantidad}, StockMin={x.StockMin}, StockMax={x.StockMax}, StockMin={x.StockMin}"));
        }

        public void Second(){
            var agotados=_Productos.Where(s=>s.Cantidad<s.StockMin).ToList();
            agotados.ForEach(y=>Console.WriteLine($"{y.NombreProduct}"));
        }
        public void Third(){
            var Comprar=_Productos.Where(s=>s.Cantidad<s.StockMin).ToList();
            Comprar.ForEach(y=>Console.WriteLine($"Esto se va a acabar {y.NombreProduct} se deben combrar {y.StockMax-y.Cantidad}"));
        }
        public void Fourth(){
            var Date=(from x in _Factura where x.Fecha.Month == 01 select x).ToList();
            Date.ForEach(x=>Console.WriteLine($"{x.NombreFact}"));
        }
    }
}