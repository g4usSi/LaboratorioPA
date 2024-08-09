using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel
{
    internal class Deluxe : Habitacion
    {
        public List<string> ServiciosExtras { get; set; } = new List<string>();
        public void AgregarDeluxe()
        {
            Console.WriteLine("\t\t\t> Deluxe <");
            Console.Write($"Numero Habitacion: ");
            int numeroHabitacion = LlenarNumeroEntero();
            Console.Write($"Precio Habitacion: ");
            double precioHabitacion = LlenarNumeroDouble();
            Console.WriteLine("Servicios Extras: ");
            string serviciosExtras = Console.ReadLine();
            ListarDeluxe(numeroHabitacion, precioHabitacion, serviciosExtras);
            Console.WriteLine("Habitacion deluxe agregada con exito...");
        }
        public void ListarDeluxe(int numero, double precio, string serviciosExtras)
        {
            bool disponible = true;
            string cliente = "";
            Numero.Add(numero);
            Precio.Add(precio);
            Disponible.Add(disponible);
            Cliente.Add(cliente);
            ServiciosExtras.Add(serviciosExtras);
        }
        public void MostrarDeluxes()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t   Habitaciones Deluxe");
            for (int i = 0; i < ServiciosExtras.Count; i++)
            {
                Console.WriteLine($"\t\tHabitacion #{i + 1}");
                Console.WriteLine($"Numero Habitacion: {Numero[i]}");
                Console.WriteLine($"Precio Habitacion: {Precio[i]}");
                Console.WriteLine($"Disponible: {Disponible[i]}");
                if (Disponible[i] == false)
                {
                    Console.WriteLine($"Cliente Asignado: {Cliente[i]}");
                }
                Console.WriteLine($"Servicios extra: {ServiciosExtras[i]}");
            }
            Console.WriteLine();
        }
        public void MostrarDeluxe(int posicion)
        {
            if (posicion >= 0) 
            {
                Console.WriteLine("\t\t\tHabitacion Deluxe #" + posicion);
                //int posicion = base.RetornoPosicion(numeroHabitacion);
                Console.WriteLine($"\t\tHabitacion: #{(posicion + 1)}");
                Console.WriteLine($"Numero Habitacion: {Numero[posicion]}");
                Console.WriteLine($"Precio: {Precio[posicion]}");
                Console.WriteLine($"Disponible: {Disponible[posicion]}");
                if (!Disponible[posicion])
                {
                    Console.WriteLine($"Cliente: {Cliente[posicion]}");
                }
                Console.WriteLine($"Servicios extra: {ServiciosExtras[posicion]}");
            }
        }
        public void EliminarDeluxe(int numeroHabitacion)
        {
            if (numeroHabitacion >= 0)
            {
                MostrarDeluxe(numeroHabitacion);
                Console.Write("> Esta segur@ que desea eliminar la habitacion: " + (numeroHabitacion + 1) + "?\n(Si/No) no se puede deshacer: ");
                string confirmacion = Console.ReadLine().ToLower();
                if (confirmacion == "Si" || confirmacion == "s")
                {
                    Numero.RemoveAt(numeroHabitacion);
                    Precio.RemoveAt(numeroHabitacion);
                    Disponible.RemoveAt(numeroHabitacion);
                    Cliente.RemoveAt(numeroHabitacion);
                    ServiciosExtras.RemoveAt(numeroHabitacion);  // Elimina el dato específico de la clase hija
                    Console.WriteLine("Habitación deluxe Eliminada.\n> Enter para continuar");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("> Regresando al menu...");
                    Console.WriteLine();
                }
            }

        }

    }

}