using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class Linq
    {
        IList<Clientes> _Cliente = new List<Clientes>()
        {
            new Clientes()
            {
                IdClient = 1,
                NombreClient = "Pepito",
                Email = "Pepito@gamil.com"
            },
            new Clientes()
            {
                IdClient = 2,
                NombreClient = "Jhoan",
                Email = "Jhoan@gamil.com"
            },
            new Clientes()
            {
                IdClient = 3,
                NombreClient = "Mariana",
                Email = "Mariana@gamil.com"
            }
        };
        List<Productos> _Productos =
            new()
            {
                new Productos()
                {
                    IdProduct = 1,
                    NombreProduct = "Tornillos",
                    PrecioUnit = 1000,
                    Cantidad = 20,
                    StockMin = 100,
                    StockMax = 200
                },
                new Productos()
                {
                    IdProduct = 2,
                    NombreProduct = "Cables",
                    PrecioUnit = 2000,
                    Cantidad = 800,
                    StockMin = 100,
                    StockMax = 800
                },
                new Productos()
                {
                    IdProduct = 3,
                    NombreProduct = "Tuercas",
                    PrecioUnit = 1000,
                    Cantidad = 60,
                    StockMin = 100,
                    StockMax = 900
                },
                new Productos()
                {
                    IdProduct = 4,
                    NombreProduct = "Bombillos",
                    PrecioUnit = 3000,
                    Cantidad = 400,
                    StockMin = 100,
                    StockMax = 400
                },
                new Productos()
                {
                    IdProduct = 5,
                    NombreProduct = "Martillos",
                    PrecioUnit = 9000,
                    Cantidad = 10,
                    StockMin = 100,
                    StockMax = 500
                },
                new Productos()
                {
                    IdProduct = 6,
                    NombreProduct = "Destornillador",
                    PrecioUnit = 600000,
                    Cantidad = 600,
                    StockMin = 100,
                    StockMax = 1000
                }
            };
        List<Factura> _Factura =
            new()
            {
                new Factura()
                {
                    NroFact = 11,
                    NombreFact = "Factura1",
                    Fecha = new DateOnly(2023, 01, 13),
                    IdCliente = 1,
                    TotalFact = 1000000
                },
                new Factura()
                {
                    NroFact = 12,
                    NombreFact = "Factura2",
                    Fecha = new DateOnly(2023, 05, 13),
                    IdCliente = 3,
                    TotalFact = 6000000
                },
                new Factura()
                {
                    NroFact = 13,
                    NombreFact = "Factura3",
                    Fecha = new DateOnly(2022, 01, 13),
                    IdCliente = 5,
                    TotalFact = 8000000
                },
                new Factura()
                {
                    NroFact = 14,
                    NombreFact = "Factura5",
                    Fecha = new DateOnly(2023, 01, 03),
                    IdCliente = 2,
                    TotalFact = 21000000
                }
            };
        List<DetalleFact> _Detalle =
            new()
            {
                new DetalleFact()
                {
                    IdDetalle = 1,
                    NroFact = 11,
                    IdProduct = 5,
                    Cantidad = 400,
                    Valor = 1000
                },
                new DetalleFact()
                {
                    IdDetalle = 2,
                    NroFact = 11,
                    IdProduct = 2,
                    Cantidad = 200,
                    Valor = 10000
                },
                new DetalleFact()
                {
                    IdDetalle = 3,
                    NroFact = 12,
                    IdProduct = 2,
                    Cantidad = 700,
                    Valor = 20000
                }

            };

        public void First()
        {
            _Productos.ForEach(
                x =>
                    Console.WriteLine(
                        $"Id={x.IdProduct}, Nombre={x.NombreProduct}, PrecioUnidad={x.PrecioUnit}, Cantidad={x.Cantidad}, StockMin={x.StockMin}, StockMax={x.StockMax}, StockMin={x.StockMin}"
                    )
            );
        }

        public void Second()
        {
            var agotados = _Productos.Where(s => s.Cantidad < s.StockMin).ToList();
            agotados.ForEach(y => Console.WriteLine($"{y.NombreProduct}"));
        }

        public void Third()
        {
            var Comprar = _Productos.Where(s => s.Cantidad < s.StockMin).ToList();
            Comprar.ForEach(
                y =>
                    Console.WriteLine(
                        $"Esto se va a acabar {y.NombreProduct} se deben combrar {y.StockMax - y.Cantidad}"
                    )
            );
        }

        public void Fourth()
        {
            var invoices = (
                from Factura in _Factura
                where Factura.Fecha.Month == 1 && Factura.Fecha.Year == 2023
                select new { NroFact = Factura.NroFact, TotalFactura = Factura.TotalFact }
            ).ToList();

            invoices.ForEach(
                Factura =>
                    Console.WriteLine(
                        $"Nro. de Factura: {Factura.NroFact}, Total de Factura: {Factura.TotalFactura}"
                    )
            );
        }

        public void Fifth()
        {
            Console.Write("Ingrese el número de factura: ");
            if (int.TryParse(Console.ReadLine(), out int nroFactura))
            {
                var productosEnFactura = (
                    from factura in _Factura
                    join detalle in _Detalle on factura.NroFact equals detalle.NroFact
                    join producto in _Productos on detalle.IdProduct equals producto.IdProduct
                    where factura.NroFact == nroFactura
                    select producto.NombreProduct
                ).ToList();

                if (productosEnFactura.Any())
                {
                    Console.WriteLine("Productos vendidos en la factura:");
                    foreach (var producto in productosEnFactura)
                    {
                        Console.WriteLine(producto);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron productos para la factura ingresada.");
                }
            }
            else
            {
                Console.WriteLine("Número de factura no válido. Debe ser un valor numérico.");
            }
        }

        public void Sixth()
        {
            var valorTotalInventario = _Productos.Sum(p => p.PrecioUnit * p.Cantidad);
            Console.WriteLine($"El valor total del inventario es: {valorTotalInventario}");
        }

        
    }
}
