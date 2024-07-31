using Programa_2;
internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 0;
        Producto productos = new Producto();
        Console.WriteLine("Administrador de Productos...");
        do
        {
            Menu();
            Console.WriteLine("Ingrese una opcion: ");
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                switch (numero)
                {
                    case 1:
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
                        break;
                    case 2:
                        productos.MostrarInformacionProducto();
                        break;
                    case 3:

                        productos.VenderProducto();
                        break;
                    case 4:
                        productos.ReestablecerStock();
                        break;
                    case 5:
                        productos.ActualizarPrecioProducto();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida...");
                        break;
                }
            }
            catch (Exception)
            {
                Console.Write("Error, intente de nuevo: ");
                continue;
            }


        } while (numero != 6);

        static void Menu()
        {
            Console.WriteLine("1. Crear un producto");
            Console.WriteLine("2. Consultar informacion de un producto");
            Console.WriteLine("3. Vender producto");
            Console.WriteLine("4. Actualizar precio de un producto");
            Console.WriteLine("5. Salir");
        }


    }
}