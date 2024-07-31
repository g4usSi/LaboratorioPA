using Programa_2;
internal class Program
{
    static int numEntero = 0;
    static double precio;
    static int stock;
    private static void Main(string[] args)
    {
        Producto productos = new Producto();
        Console.WriteLine("Administrador de Productos...");
        do
        {
            Menu();

            switch ()
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Precio: ");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Stock: ");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    productos.AgregarProducto(nombre, precio, stock);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opcion invalida...");
                    break;
            }
        } while (numEntero != 6);

        static void Menu()
        {
            Console.WriteLine("1. Crear un producto");
            Console.WriteLine("2. Consultar informacion de un producto");
            Console.WriteLine("3. Vender producto");
            Console.WriteLine("4. Reestablecer Stock de un producto");
            Console.WriteLine("5. Reestablecer Stock de un producto");
            Console.WriteLine("6. Salir");
        }
        static void 


    }
}