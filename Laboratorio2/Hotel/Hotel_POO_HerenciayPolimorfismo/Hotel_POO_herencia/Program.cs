using Hotel_POO_herencia;
List<Habitacion> listaHabitaciones = new List<Habitacion>();
Habitacion hotel = new Habitacion();
int opcion;
bool exit = false;
do
{
    Menu();
    Console.Write("> Ingrese una opcion: ");
    opcion = hotel.LlenarNumeroEntero();
    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Agregar Habitacion ***");
            SubMenu();
            Console.Write("> Ingrese una opcion: ");
            switch (opcion = hotel.LlenarNumeroEntero())
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
                    Suite habitacionSuite = new Suite();
                    habitacionSuite.AgregarHabitacion();
                    listaHabitaciones.Add(habitacionSuite);
                    break;
                case 4:
                    Deluxe habitacionDeluxe = new Deluxe();
                    habitacionDeluxe.AgregarHabitacion();
                    listaHabitaciones.Add(habitacionDeluxe);
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta\n> Regresando al menu...");
                break;
            }
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Eliminar Habitacion ***");
            hotel.EliminarHabitacion(listaHabitaciones);
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Mostrar Habitaciones ***");
            hotel.MostrarTodasHabitaciones(listaHabitaciones);
            break;
        case 4:
            Console.WriteLine("\t\t\t*** Asignar Habitacion a Cliente ***");
            hotel.AsignarHabitacion(hotel.BuscarHabitacion(listaHabitaciones));
            break;
        case 5:
            Console.WriteLine("\t\t\t*** Liberar Habitacion ***");
            hotel.LiberarHabitacion(hotel.BuscarHabitacion(listaHabitaciones));
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
    Console.WriteLine("1. Registrar Cliente");
    Console.WriteLine("2. Registrar Vehiculo");
    Console.WriteLine("3. Registrar Pedidos");
    Console.WriteLine("4. Registrar Pedidos");
    Console.WriteLine("5. Mostrar Todo");
    Console.WriteLine("6. Salir");
}
static void SubMenu()
{
    Console.WriteLine("\t\t\t   ");
    Console.WriteLine("1. Habitacion Simple");
    Console.WriteLine("2. Habitacion Doble");
    Console.WriteLine("3. Suite");
    Console.WriteLine("4. Habitacion Deluxe");
}