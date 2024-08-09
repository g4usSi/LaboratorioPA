using Hotel;
Habitacion hotel = new Habitacion();
//utilidades principales
//Primera version del programa
//se puede realizar con una lista de objetos


//REHACER CODIGO CON POLIMORFISMO
HabitacionSimple habitacionSimple = new HabitacionSimple();
HabitacionDoble habitacionDoble = new HabitacionDoble();
Suite suite = new Suite();
Deluxe deluxe = new Deluxe();

int indexer;
int posicionSimple, posicionDoble, posicionSuite, posicionDeluxe;
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
                    habitacionSimple.AgregarHabitacionSimple();
                    break;
                case 2:
                    habitacionDoble.AgregarHabitacionDoble();
                    break;
                case 3:
                    suite.AgregarSuite();
                    break;
                case 4:
                    deluxe.AgregarDeluxe();
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta\n> Regresando al menu...");
                break;
            }
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Eliminar Habitacion ***");
            indexer = hotel.NumeroHabitacion();
            //lo busca en los 3
            posicionSimple = habitacionSimple.BuscarHabitacion(indexer);
            posicionDoble = habitacionDoble.BuscarHabitacion(indexer);
            posicionSuite = suite.BuscarHabitacion(indexer);
            posicionDeluxe = deluxe.BuscarHabitacion(indexer);

            habitacionSimple.EliminarHabitacionSimple(habitacionSimple.BuscarHabitacion(indexer));
            habitacionDoble.EliminarHabitacionDoble(habitacionDoble.BuscarHabitacion(indexer));
            suite.EliminarSuite(suite.BuscarHabitacion(indexer));
            deluxe.EliminarDeluxe(deluxe.BuscarHabitacion(indexer));
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("\t\t\t*** Mostrar Habitaciones ***");
            habitacionSimple.MostrarHabitacionesSimples();
            habitacionDoble.MostrarHabitacionesDobles();
            suite.MostrarSuites();
            deluxe.MostrarDeluxes();
            break;
        case 4:
            Console.WriteLine("\t\t\t*** Asignar Habitacion a Cliente ***");
            indexer = hotel.NumeroHabitacion();
            //lo busca en los 3
            posicionSimple = habitacionSimple.BuscarHabitacion(indexer);
            posicionDoble = habitacionDoble.BuscarHabitacion(indexer);
            posicionSuite = suite.BuscarHabitacion(indexer);
            posicionDeluxe = deluxe.BuscarHabitacion(indexer);

            if (posicionSimple < 0 && posicionDoble < 0 && posicionSuite < 0 && posicionDeluxe < 0)
            {
                Console.WriteLine("[!] Error no existe la habitacion...");
                Console.WriteLine("Regresando al menu...");
            }
            else
            {
                //funciona como llaves los if integrado en cada metodo....
                habitacionSimple.MostrarHabitacionSimple(posicionSimple);
                habitacionSimple.AsignarHabitacion(posicionSimple);

                habitacionDoble.MostrarHabitacionDoble(posicionDoble);
                habitacionDoble.AsignarHabitacion(posicionDoble);

                suite.MostrarSuite(posicionSuite);
                suite.AsignarHabitacion(posicionSuite);

                deluxe.MostrarDeluxe(posicionDeluxe);
                deluxe.AsignarHabitacion(posicionDeluxe);
            }
            break;
        case 5:
            Console.WriteLine("\t\t\t*** Liberar Habitacion ***");
            indexer = hotel.NumeroHabitacion();
            posicionSimple = habitacionSimple.BuscarHabitacion(indexer);
            posicionDoble = habitacionDoble.BuscarHabitacion(indexer);
            posicionSuite = suite.BuscarHabitacion(indexer);
            posicionDeluxe = deluxe.BuscarHabitacion(indexer);

            if (posicionSimple < 0 && posicionDoble < 0 && posicionSuite < 0 && posicionDeluxe < 0)
            {
                Console.WriteLine("[!] Error no existe la habitacion...");
                Console.WriteLine("Regresando al menu...");
            }
            else 
            {
                habitacionSimple.LiberarHabitacion(posicionSimple);
                habitacionDoble.LiberarHabitacion(posicionDoble);
                suite.LiberarHabitacion(posicionSuite);
                deluxe.LiberarHabitacion(posicionDeluxe);
            }
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