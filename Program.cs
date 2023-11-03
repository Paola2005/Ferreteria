using System;
using Ferreteria.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Linq Ferreteria = new Linq();
        bool peligro = true;
        while (peligro)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************************************");
            Console.WriteLine("************ FERRETERIA UNICA **************");
            Console.WriteLine("********************************************");
            Console.ResetColor();
            Console.WriteLine("\nElije una opción:");
            Console.WriteLine("1. Listar Productos");
            Console.WriteLine("2. Productos a punto de agotarse");
            Console.WriteLine("3. Productos a comprar y cantidad");
            Console.WriteLine("4. Total de Facturas de enero 2023");
            Console.WriteLine("5. Productos vendidos en factura");
            Console.WriteLine("6. Valor total del inventario");
            Console.WriteLine("7. Salir");
            Console.Write("Opción: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("************ Listado de Productos ************\n");
                    Console.ResetColor();
                    Ferreteria.First();
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("******** Productos a punto de agotarse ********\n");
                    Console.ResetColor();
                    Ferreteria.Second();
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****** Productos a comprar y cantidad ******\n");
                    Console.ResetColor();
                    Ferreteria.Third();
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** Total de Facturas de enero 2023 *****\n");
                    Console.ResetColor();
                    Ferreteria.Fourth();
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("****** Productos vendidos en factura ******\n");
                    Console.ResetColor();
                    Ferreteria.Fifth();
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "6":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****** Valor Total del Inventario ******\n");
                    Console.ResetColor();
                    Ferreteria.Sixth();
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "7":
                    peligro = false;
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
