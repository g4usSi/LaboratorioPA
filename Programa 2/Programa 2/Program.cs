using Programa_2;
internal class Program
{
    static double Valor;
    static int Cantidad;
    private static void Main(string[] args)
    {
        int numero = 0;
        Producto productos = new Producto();
        Console.WriteLine("Administrador de Productos...");
        do
        {
            Menu();
            Console.Write("Ingrese una opcion: ");
                numero = productos.LlenarNumeroEntero();
                switch (numero)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--- Crear un producto ---");
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Precio: ");

                        double precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Stock: ");
                        int stock = Convert.ToInt32(Console.ReadLine());
                        if (nombre != "" && precio >= 0 && stock >= 0)
                        {
                            productos.AgregarProducto(nombre, precio, stock);
                        }
                        else
                        {
                            Console.WriteLine("Error uno de sus parametros es incorrecto");
                        }
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("--- Consultar informacion de un producto ---");
                        productos.MostrarInformacionProducto();
                    Console.WriteLine();
                    break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("--- Vender producto ---");
                        productos.VenderProducto();
                    Console.WriteLine();
                    break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("--- Reestablecer Stock ---");
                        Console.WriteLine();
                        productos.ReestablecerStock();
                    Console.WriteLine();
                    break;
                    case 5:
                        Console.Clear();
                    Console.WriteLine("--- Actualizar precio de un producto ---");
                        Console.WriteLine();
                        productos.ActualizarPrecioProducto();
                    Console.WriteLine();
                    break;
                    default:
                        Console.WriteLine("Opcion invalida...");
                    Console.WriteLine();
                    break;
                }
        } while (numero != 6);

        static void Menu()
        {
            Console.WriteLine("1. Crear un producto");
            Console.WriteLine("2. Consultar informacion de un producto");
            Console.WriteLine("3. Vender producto");
            Console.WriteLine("4. Reestablecer Stock");
            Console.WriteLine("5. Actualizar precio de un producto");
            Console.WriteLine("6. Salir");
        }
    }
}