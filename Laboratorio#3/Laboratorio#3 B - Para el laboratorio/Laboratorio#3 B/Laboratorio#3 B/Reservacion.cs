using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_B
{
    internal class Reservacion
    {
        public int NumeroReservacion { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public double TotalCuenta { get; set; }
        public List<Platillo> ComidaReservada { get; set; } = new List<Platillo>();
        public List<Platillo> Platillos { get; set; } = new List<Platillo>
        {
        new Platillo("Espaguetti", 50.50),
        new Platillo("Rizzoto", 80.00),
        new Platillo("Pizza", 15.00),
        new Platillo("Carbonara", 75.00),
        };

        public Reservacion() { }
        //Agregar nueva reservacion
        public void RegistrarNuevaReservacion(int numeroReservacion, List<Cliente> listaClientes)
        {
            bool continuar = false;
            double total = 0;
            if (numeroReservacion >= 0)
            {
                this.NumeroReservacion = numeroReservacion;
                Console.WriteLine("Ingrese la fecha de reservacion...");
                Console.Write("\t> Ingrese dia: ");
                int fecha = LlenarNumeroEntero();
                Console.Write("\t> Ingrese mes: ");
                int mes = LlenarNumeroEntero();
                Console.Write("\t> Ingrese año: ");
                int año = LlenarNumeroEntero();
                this.Fecha = new DateTime(año, mes, fecha);
                Cliente clienteActual = Cliente.BuscarCliente(listaClientes);
                while (clienteActual == null)
                {
                    clienteActual = Cliente.BuscarCliente(listaClientes);
                    if (clienteActual == null)
                    {
                        Console.WriteLine("El cliente no existe en la lista de clientes...");
                        Console.WriteLine("Vuelva a ingresar los datos...");
                    }
                }
                Cliente = clienteActual;
                Platillo.MostrarTodosPlatillos(Platillos);
                do
                {
                    Platillo platillo = Platillo.RetornarPlatillo(Platillos);
                    if (platillo != null)
                    {
                        ComidaReservada.Add(platillo);
                        total += platillo.PrecioPlatillo;
                        Console.WriteLine("El total es: Q" + total);
                    }
                    else
                    {
                        Console.WriteLine("[!] Error no se ha encontrado el platillo...");
                        Console.WriteLine("El total actual es: Q" + total);
                    }
                    Console.Write("Desea seguir agregando platillos? (Si/No): ");
                    string ciclo = Console.ReadLine().ToLower();
                    continuar = (ciclo == "si" || ciclo == "s");
                } while (continuar);
                double totalCuenta = clienteActual.AplicarDescuento(total);
                Console.WriteLine("El total de la cuenta es: Q" + totalCuenta);
                TotalCuenta = totalCuenta;
            }
            else
            {
                Console.WriteLine("> Regresando al menu...");
                return;
            }
        }
        public int NumReservacion(List<Reservacion> listaReservaciones)
        {
            Console.Write("> Ingrese el numero de reservacion: ");
            int numeroReservacion = LlenarNumeroEntero();
            foreach (var reservation in listaReservaciones)
            {
                if (numeroReservacion == reservation.NumeroReservacion)
                {
                    Console.WriteLine("[!] Ya hay una reservacion con este numero...");
                    return -1;
                }
            }
            return numeroReservacion;
        }
        public Reservacion BuscarReservacion(List<Reservacion> listaReservaciones)
        {
            Console.Write("Ingrese el numero de la reservacion: ");
            int reservacionBuscar = LlenarNumeroEntero();
            Reservacion reservacionEncontrada = listaReservaciones.Find(r => r.NumeroReservacion.Equals(reservacionBuscar));
            if (reservacionEncontrada != null)
            {
                return reservacionEncontrada;
            }
            else
            {
                Console.WriteLine("[!] La reservacion no existe");
                return null;
            }
        }
        //Mostrar todas las reservaciones y detalles del cliente
        public static void MostrarReservaciones(List<Reservacion> reservaciones) 
        {
            if (reservaciones.Count > 0)
            {
                Console.WriteLine();
                foreach (var res in reservaciones) 
                {
                    res.MostrarReservacionUnica(res);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("[!] Aun no hay reservaciones en el sistema....");  
                return;
            }
        }
        public void MostrarReservacionUnica(Reservacion reservacion) {
            Console.WriteLine($"\t\t\tNumero de reservacion: {NumeroReservacion}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Cliente: {Cliente.Nombre}");
            if (Cliente.Descuento > 0)
            {
                Console.WriteLine("Cliente VIP");
            }
            else
            {
                Console.WriteLine("Cliente Regular");
            }
            Console.WriteLine($"Comida reservada:");
            MostrarComidaReservada();
            Console.WriteLine($"\t\t-------- Total de la cuenta: Q{TotalCuenta} --------");
        }
        public void MostrarComidaReservada()
        {
            foreach (var comidaReservada in ComidaReservada)
            {
                comidaReservada.MostrarPlatillo();
            }
        }
        //Mostrar cliente o reserva
        public void BuscarClienteoReserva(List<Cliente> listaClientes, List<Reservacion> listaReservaciones) 
        {
            Console.WriteLine("[ 1 ] Buscar por cliente: ");
            Console.WriteLine("[ 2 ] Buscar por numero de reservacion: ");
            int opcion = LlenarNumeroEntero();
            switch (opcion) 
            {
                case 1:
                    Cliente clienteActual = Cliente.BuscarCliente(listaClientes);
                    Cliente.MostrarInformacionCliente(clienteActual);
                    break;
                case 2:
                    Reservacion reservacionActual = BuscarReservacion(listaReservaciones);
                    reservacionActual.MostrarReservacionUnica(reservacionActual);
                    break;
                default:
                    Console.WriteLine("Error no ha ingresado una opcion valida...");
                    Console.WriteLine("> Regresando al Menu...");
                return;
            }
        }

        //Metodos Basicos de ingreso de datos
        public int LlenarNumeroEntero()
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
        public double LlenarNumeroDouble()
        {
            double numeroDouble = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    numeroDouble = Convert.ToDouble(Console.ReadLine());
                    valido = true;
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
            return numeroDouble;
        }

    }
}