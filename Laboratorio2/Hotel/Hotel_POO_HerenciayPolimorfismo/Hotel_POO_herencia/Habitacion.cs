using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_POO_herencia
{
    internal class Habitacion
    {
        public int Numero { get; set; }
        public double Precio { get; set; }
        public bool Disponible { get; set; }
        public string Cliente { get; set; }
        public Habitacion(int numeroHabitacion, double precioHabitacion, bool disponible, string clienteAsignado)
        {
            this.Numero = numeroHabitacion;
            this.Precio = precioHabitacion;
            this.Disponible = disponible;
            this.Cliente = clienteAsignado;
        }
        //constructor para Main
        public Habitacion() { }
        public virtual void AgregarHabitacion() 
        {
            Console.Write($"Numero Habitacion: ");
            this.Numero = LlenarNumeroEntero();
            Console.Write($"Precio Habitacion: ");
            this.Precio = LlenarNumeroDouble();
            this.Disponible = true;
            this.Cliente = "";
        }
        //Funcion de retorno objeto
        public Habitacion BuscarHabitacion(List<Habitacion> listaHabitaciones) 
        {
            if (listaHabitaciones.Count > 0)
            {
                Console.Write("> Ingrese el numero de habitacion: ");
                int numeroHabitacion = LlenarNumeroEntero();
                Habitacion habitacion = listaHabitaciones.Find(habitacion => habitacion.Numero == numeroHabitacion);
                if (habitacion == null)
                {
                    Console.WriteLine("[!] La habitacion no existe...");
                    Console.WriteLine();
                    return null;
                }
                //sobrecargando metodos, especificos para ese objeto
                habitacion.MostrarHabitacionUnica(habitacion);
                return habitacion;
            }
            else 
            {
                Console.WriteLine("[!] Aun no hay habitaciones en el sistema...");
                Console.WriteLine();
                return null;
            }
        }
        //Mostrar todas las habitaciones
        public void MostrarTodasHabitaciones(List<Habitacion> habitaciones)
        {
            foreach (Habitacion habitacion in habitaciones)
            {
                //polimorfismo y sobrecarga
                habitacion.MostrarHabitacionUnica(habitacion);
            }
        }
        //Mostrar una habitacion unica
        public virtual void MostrarHabitacionUnica(Habitacion habitacion)
        {
            if (habitacion != null)
            {
                Console.WriteLine();
                Console.WriteLine($"\t\t\t/// Numero Habitacion {habitacion.Numero} ///");
                Console.WriteLine($"Precio Habitacion: Q{habitacion.Precio}");
                Console.WriteLine($"Disponible: {EnmascaradoDisponible(habitacion.Disponible)}");
                if (habitacion.Disponible == false)
                {
                    Console.WriteLine($"Cliente Asignado: {habitacion.Cliente}");
                }
            }
            else
            {
                return;
            }
        }
        //Eliminar objeto
        public void EliminarHabitacion(List<Habitacion> listaHabitaciones)
        {
            Habitacion habitacionEliminar = BuscarHabitacion(listaHabitaciones);
            if (habitacionEliminar != null) 
            {
                Console.WriteLine("Esta segur@ que desea eliminar la habitacion? (Si/No)");
                string confirmacion = Console.ReadLine().ToLower();
                if (confirmacion == "si" || confirmacion == "s")
                {
                    listaHabitaciones.Remove(habitacionEliminar);
                }
                else
                {
                    Console.WriteLine($"No se ha eliminado... la habitacion: {habitacionEliminar.Numero}");
                }
            }
        }
        public void AsignarHabitacion(Habitacion habitacion)
        {
            if (habitacion != null)
            {
                if (habitacion.Disponible)
                {
                    Console.WriteLine();
                    Console.Write("> Ingrese el nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();
                    habitacion.Cliente = nombreCliente;
                    habitacion.Disponible = false;
                    Console.WriteLine("Habitacion reservada a: " + nombreCliente);
                }
                else
                {
                    Console.WriteLine("[!] La habitacion ya esta ocupada");
                }
                Console.WriteLine("\nRegresando al menu...\n");
            }
        }
        public void LiberarHabitacion(Habitacion habitacion)
        {
            bool seguridad = false;
            if (habitacion != null)
            {
                if (!habitacion.Disponible)
                {
                    Console.WriteLine("Esta segur@ que desea liberar esta habitacion...");
                    string confirmacion = Console.ReadLine().ToLower();
                    seguridad = (confirmacion == "si" || confirmacion == "s");
                    if (seguridad == true)
                    {
                        habitacion.Cliente = "";
                        habitacion.Disponible = true;
                        Console.WriteLine($"Se ha liberado la habitacion: {habitacion.Numero}");
                    }
                    else
                    {
                        Console.WriteLine("No se ha liberado la habitacion...\nRegresando al menu...");
                    }
                }
                else
                {
                    Console.WriteLine("[!] La habitacion no esta ocupada...");
                }
            }
        }
        
        //Funciones Basicas
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
                        if (numeroEntero <= 0)
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
                    Console.WriteLine("[!] Error desconocido... "+ex);
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
                catch (Exception)
                {
                    Console.WriteLine("[!] Error desconocido... ");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroDouble;
        }
        //Enmascaraco
        public string EnmascaradoDisponible(bool disponible) 
        {
            if (disponible)
            {
                return "Disponible";
            }
            else
            {
                return "Ocupado";
            }
        }
        public string EnmascaradoTiene(bool disponible)
        {
            if (disponible)
            {
                return "Tiene";
            }
            else
            {
                return "No tiene";
            }
        }

    }
}
