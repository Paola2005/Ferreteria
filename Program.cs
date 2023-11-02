using Ferreteria.Clases;

internal class Program{
    private static void Main(string[] args){
        Linq Ferreteria=new Linq();
        bool peligro=true;
            while ( peligro==true){
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||FERRETERIA UNICA||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("");
            Console.WriteLine("1. Listar Productos");
            Console.WriteLine("2. Productos que estan a punto de agotarse");
            Console.WriteLine("3. Productos que se deben comprar y cantidad ");
            Console.WriteLine("4. Total de facturas");
            Console.WriteLine("5. Productos vendidos");
            Console.WriteLine("6. Valor total del inventario");
            Console.WriteLine("Elije una opcion:");
            var option =Console.ReadLine();
            switch(option){
                case "1":
                Ferreteria.First();
                Console.ReadKey();
                Console.WriteLine("");
                break;
                case "2":
                Ferreteria.Second();
                Console.ReadKey();
                Console.WriteLine("");
                break;
                case "3":
                Ferreteria.Third();
                Console.ReadKey();
                Console.WriteLine("");
                break;
                case "4":
                Ferreteria.Fourth();
                Console.ReadKey();
                Console.WriteLine("");
                break;
                case "5":
                Ferreteria.Fifth();
                Console.ReadKey();
                Console.WriteLine("");
                break;
                case "6":
                Ferreteria.Sixth();
                Console.ReadKey();
                Console.WriteLine("");
                break;
                default:
                Console.WriteLine("Chao");
                peligro=false;
                break;
            }
        }
    }
}