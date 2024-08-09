using Hotel;

HabitacionSimple habitacionSimple = new HabitacionSimple();
int opcion;
do 
{
    Menu();
    Console.Write("> Ingrese una opcion: ");
    opcion = habitacionSimple.LlenarNumeroEntero();
    switch (opcion) 
    {
        case 1:
            SubMenu();
            Console.Write(">Ingrese una opcion: ");
            switch (opcion = habitacionSimple.LlenarNumeroEntero()) 
            {
                case 1:
                    habitacionSimple.AgregarHabitacionSimple();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            break;
        case 2:

            habitacionSimple.EliminarHabitacionSimple(habitacionSimple.BuscarHabitacion());
            break;
        case 3:
            habitacionSimple.MostrarHabitacionesSimples();
            break;
        case 4:
            break;
        case 5:
            break; 
        case 6:
            break;
    }
} while (true);

static void Menu()
{
    Console.WriteLine("1. Agregar Habitacion");
    Console.WriteLine("2. Eliminar Habitacion");
    Console.WriteLine("3. Mostrar Habitaciones");
    Console.WriteLine("4. Asignar Habitacion a Cliente");
    Console.WriteLine("5. Liberar Habitacion");
    Console.WriteLine("6. Salir");
}
static void SubMenu() 
{
    Console.WriteLine("1. Habitacion Simple");
    Console.WriteLine("2. Habitacion Doble");
    Console.WriteLine("3. Suite");
    Console.WriteLine("4. Habitacion Deluxe");
}