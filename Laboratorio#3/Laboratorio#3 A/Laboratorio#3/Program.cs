using Laboratorio_3;

Cliente clientes = new Cliente();
int opcion;
bool exit = false;
do
{
    Menu();
    Console.Write("> Ingrese una opcion: ");
    opcion = clientes.LlenarNumeroEntero();
    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Agregar Habitacion ***");
            SubMenu();
            Console.Write("> Ingrese una opcion: ");
            switch (opcion = clientes.LlenarNumeroEntero())
            {
                case 1:
                    HabitacionSimple habitacionSimple = new HabitacionSimple();
                    habitacionSimple.AgregarHabitacion();
                    listaHabitaciones.Add(habitacionSimple);
                    break;
                case 2:
                    HabitacionDoble habitacionDoble = new HabitacionDoble();
                    habitacionDoble.AgregarHabitacion();
                    listaHabitaciones.Add(habitacionDoble);
                    break;
                case 3:
                    Suite suite = new Suite();
                    suite.AgregarHabitacion();
                    listaHabitaciones.Add(suite);
                    break;
                case 4:
                    //deluxe.AgregarDeluxe();
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta\n> Regresando al menu...");
                    break;
            }
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Eliminar Habitacion ***");
            clientes.EliminarHabitacion(listaHabitaciones);
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Mostrar Habitaciones ***");
            clientes.MostrarTodasHabitaciones(listaHabitaciones);
            break;
        case 4:
            Console.WriteLine("\t\t\t*** Asignar Habitacion a Cliente ***");
            clientes.AsignarHabitacion(clientes.BuscarHabitacion(listaHabitaciones));
            break;
        case 5:
            Console.WriteLine("\t\t\t*** Liberar Habitacion ***");
            clientes.LiberarHabitacion(clientes.BuscarHabitacion(listaHabitaciones));
            break;
        case 6:
            Console.Clear();
            Console.WriteLine("Segur@ desea salir? (Si/No): ");
            string salir = Console.ReadLine().ToLower();
            exit = (salir == "si") || (salir == "s");
            break;
        default:
            Console.WriteLine("Opcion incorrecta\n> Regresando al menu...");
            break;
    }
} while (!exit);
static void Menu()
{
    Console.WriteLine("\t\t\tMenu Principal");
    Console.WriteLine("1. Agregar Habitacion");
    Console.WriteLine("2. Eliminar Habitacion");
    Console.WriteLine("3. Mostrar Habitaciones");
    Console.WriteLine("4. Asignar Habitacion a Cliente");
    Console.WriteLine("5. Liberar Habitacion");
    Console.WriteLine("6. Salir");
}
static void SubMenu()
{
    Console.WriteLine("\t\t\t   Tipos de habitacion");
    Console.WriteLine("1. Habitacion Simple");
    Console.WriteLine("2. Habitacion Doble");
    Console.WriteLine("3. Suite");
    Console.WriteLine("4. Habitacion Deluxe");
}