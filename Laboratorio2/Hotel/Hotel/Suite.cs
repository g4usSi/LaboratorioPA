using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel
{
    internal class Suite : Habitacion
    {
        public List<int> Habitaciones { get; set; } = new List<int>();
        public List<bool> Jacuzzi { get; set; } = new List<bool>();
        public void AgregarSuite()
        {
            Console.WriteLine("\t\t\t> Suite <");
            Console.Write($"Numero Habitacion: ");
            int numeroHabitacion = LlenarNumeroEntero();
            Console.Write($"Precio Habitacion: ");
            double precioHabitacion = LlenarNumeroDouble();
            Console.Write($"Numero de habitaciones: ");
            int numeroHabitaciones = LlenarNumeroEntero();
            Console.Write($"Tiene jacuzzi: ");
            string tiene = Console.ReadLine().ToLower();
            bool tieneJacuzzi = (tiene == "si" || tiene == "s");
            ListarSuite(numeroHabitacion, precioHabitacion, numeroHabitaciones, tieneJacuzzi);
            Console.WriteLine("Habitacion suite agregada con exito...");
        }
        public void ListarSuite(int numero, double precio, int numHabitaciones, bool jacuzzi)
        {
            bool disponible = true;
            string cliente = "";
            Numero.Add(numero);
            Precio.Add(precio);
            Disponible.Add(disponible);
            Cliente.Add(cliente);
            Habitaciones.Add(numHabitaciones);
            Jacuzzi.Add(jacuzzi);
        }
        public void MostrarSuites()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t   Habitaciones Suite");
            for (int i = 0; i < Jacuzzi.Count; i++)
            {
                Console.WriteLine($"\t\tSuite #{i + 1}");
                Console.WriteLine($"Numero Habitacion: {Numero[i]}");
                Console.WriteLine($"Precio Habitacion: {Precio[i]}");
                Console.WriteLine($"Disponible: {Disponible[i]}");
                if (Disponible[i] == false)
                {
                    Console.WriteLine($"Cliente Asignado: {Cliente[i]}");
                }
                Console.WriteLine($"Numero de habitaciones: {Habitaciones[i]}");
                Console.WriteLine($"Tiene jacuzzi: {Jacuzzi[i]}");
            }
            Console.WriteLine();
        }
        public void MostrarSuite(int posicion)
        {
            if (posicion >= 0) 
            {
                Console.WriteLine("\t\t\tHabitacion Suite #" + posicion);
                //int posicion = base.RetornoPosicion(numeroHabitacion);
                Console.WriteLine($"\t\tSuite: #{(posicion + 1)}");
                Console.WriteLine($"Numero Habitacion: {Numero[posicion]}");
                Console.WriteLine($"Precio: {Precio[posicion]}");
                Console.WriteLine($"Disponible: {Disponible[posicion]}");
                if (!Disponible[posicion])
                {
                    Console.WriteLine($"Cliente: {Cliente[posicion]}");
                }
                Console.WriteLine($"Numero de habitaciones: {Habitaciones[posicion]}");
                Console.WriteLine($"Tiene jacuzzi: {Jacuzzi[posicion]}");
            }
        }
        public void EliminarSuite(int numeroHabitacion)
        {
            if (numeroHabitacion >= 0)
            {
                MostrarSuite(numeroHabitacion);
                Console.Write("> Esta segur@ que desea eliminar la habitacion: " + (numeroHabitacion + 1) + "?\n(Si/No) no se puede deshacer: ");
                string confirmacion = Console.ReadLine().ToLower();
                if (confirmacion == "Si" || confirmacion == "s")
                {
                    Numero.RemoveAt(numeroHabitacion);
                    Precio.RemoveAt(numeroHabitacion);
                    Disponible.RemoveAt(numeroHabitacion);
                    Cliente.RemoveAt(numeroHabitacion);
                    Habitaciones.RemoveAt(numeroHabitacion);
                    Jacuzzi.RemoveAt(numeroHabitacion);
                    Console.WriteLine("Habitación suite Eliminada.\n> Enter para continuar");
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