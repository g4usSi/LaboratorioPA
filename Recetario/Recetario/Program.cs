using Recetario;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.WriteLine("recetario");
Receta recetario = new Receta();
int numero;
Console.WriteLine("########## RECETARIO ##########");
do
{
    Menu();
    Console.Write("Ingrese una opcion: ");
    numero = recetario.LlenarNumeroEntero();
    switch (numero)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("--- Crear un producto ---");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Tiempo de Coccion: ");

            double tiempo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Descripcion: ");
            string descripcion = Console.ReadLine();
            if (nombre != "" && tiempo >= 0 && descripcion != "")
            {
                recetario.AgregarReceta(nombre, descripcion, tiempo);
            }
            else
            {
                Console.WriteLine("Error al menos uno de sus parametros es incorrecto");
            }
            Console.WriteLine();

            break;
        case 2:
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("--- Mostrar recetas ---");
            recetario.MostrarRecetas();
            Console.WriteLine();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("--- Buscar receta ---");
            recetario.MostrarReceta(recetario.BuscarReceta());
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Opcion invalida...");
            Console.WriteLine();
            break;
    }
} while (numero != 4);

static void Menu()
{
    Console.WriteLine("1. Agregar receta");
    Console.WriteLine("2. Mostrar Recetas");
    Console.WriteLine("3. Buscar Receta");
    Console.WriteLine("4. Salir");
}