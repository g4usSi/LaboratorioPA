using Laboratorio_3_B;
using System.Collections.Specialized;
using System.Net;

Reservacion administrador = new Reservacion();
List<Cliente> listaClientes = new List<Cliente>();
List<Reservacion> listaReservaciones = new List<Reservacion>();
int opcion;
bool continuarSubmenu = true, continuarMenu = false;
Console.Write("Ingrese una opcion: ");

do
{
    MenuPrincipal();
    Console.Write("Ingrese una opcion: ");
    switch (opcion = LlenarNumeroEntero())
    {
        case 1:
            Console.Clear();
            Console.WriteLine("\t\t\tREGISTRAR UN NUEVO CLIENTE");
            SubMenu();
            Console.Write("Ingrese una opcion: ");
            switch (opcion = LlenarNumeroEntero())
            {
                case 1:
                    Console.WriteLine("\t\t\t> Cliente Regular <");
                    Cliente cliente = new Cliente();
                    cliente.RegistrarCliente();
                    listaClientes.Add(cliente);
                    break;
                case 2:
                    ClienteVIP clienteVIP = new ClienteVIP();
                    clienteVIP.RegistrarCliente();
                    listaClientes.Add(clienteVIP);
                    break;
                case 3:
                    Console.WriteLine("> Regresando al menu...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida...");
                    break;
            }
            break;

        case 2:
            Console.WriteLine("\t\t\tREGISTRAR RESERVACION");
            Reservacion reservacion = new Reservacion();
            reservacion.RegistrarNuevaReservacion(reservacion.NumReservacion(listaReservaciones), listaClientes);
            listaReservaciones.Add(reservacion);
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("\t\t\tMOSTRAR DETALLES DEL CLIENTE Y RESERVAS");
            Reservacion.MostrarReservaciones(listaReservaciones);
            break;

        case 4:
            Console.Clear();
            Console.WriteLine("\t\t\tBUSCAR CLIENTE O RESERVAS");
            administrador.BuscarClienteoReserva(listaClientes, listaReservaciones);
            break;

        case 5:
            continuarMenu = false;
        break;
    }
}while (!continuarMenu);

static void MenuPrincipal()
{
    Console.WriteLine("\t\t\tMenu Principal");
    Console.WriteLine("[ 1 ] Registrar Cliente");
    Console.WriteLine("[ 2 ] Registrar una Reservacion");
    Console.WriteLine("[ 3 ] Mostrar detalles del cliente y reservas");
    Console.WriteLine("[ 4 ] Buscar cliente o reservas");
    Console.WriteLine("[ 5 ] Salir");
}
static void SubMenu()
{
    Console.WriteLine("\t\t\tIngrese el tipo de cliente");
    Console.WriteLine("[ 1 ] Cliente regular");
    Console.WriteLine("[ 2 ] Cliente VIP");
    Console.WriteLine("[ 5 ] Salir");
}
static int LlenarNumeroEntero()
{
    int numeroEntero = 0;
    bool valido = false;
    while (!valido)
    {
        try
        {
            while (numeroEntero <= 0)
            {
                numeroEntero = Convert.ToInt32(Console.ReadLine());
                if (numeroEntero < 0)
                {
                    Console.Write("No puede ingresar numeros negativos...\nIntente de nuevo: ");
                }
                valido = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("[!] Error no puede ingresar letras...");
            Console.Write("> Intente de nuevo: ");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[!] Error desconocido... " + ex + "\n");
            Console.Write("> Intente de nuevo: ");
        }
    }
    return numeroEntero;
}