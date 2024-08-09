using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class HabitacionSimple : Habitacion
    {
        public List<int> NumeroDeCamas { get; set; } = new List<int>();

        public void AgregarHabitacionSimple() 
        {
            Console.WriteLine($"Numero Habitacion: ");
            int numeroHabitacion = LlenarNumeroEntero();
            Console.WriteLine($"Precio Habitacion: ");
            double precioHabitacion = LlenarNumeroDouble();
            Console.Write("Numero de camas: ");
            int numeroDeCamas = base.LlenarNumeroEntero();
            ListarHabitacionSimple(numeroHabitacion, precioHabitacion);
            Console.WriteLine("Habitacion simple agregada con exito...");
        }
        public void ListarHabitacionSimple(int numeroDeCamas) 
        {
            bool disponible = true;
            string cliente = "";
            Numero.Add(numero);
            Precio.Add(precio);
            Disponible.Add(disponible);
            Cliente.Add(cliente);
            NumeroDeCamas.Add(numeroDeCamas);
        }
        public void MostrarHabitacionesSimples() 
        {
            Console.WriteLine("\t\t\tHabitaciones Simples");
            for (int i = 0; i < NumeroDeCamas.Count; i++)
            {
                Console.WriteLine($"\t\tHabitacion #{i + 1}");
                Console.WriteLine($"Numero Habitacion: {Numero[i]}");
                Console.WriteLine($"Precio Habitacion: {Precio[i]}");
                Console.WriteLine($"Disponible: {Disponible[i]}"); 
                if (Disponible[i] == false)
                {
                    Console.WriteLine($"Cliente Asignado: {Cliente[i]}");
                    continue;
                }
                Console.WriteLine($"Numero de camas: {NumeroDeCamas[i]}");
            }
            Console.WriteLine();
        }
        public void MostrarHabitacionSimple(int posicion)
        {
            //int posicion = base.RetornoPosicion(numeroHabitacion);
            if (posicion >= 0)
            {

                Console.WriteLine($"\t\tHabitacion: #{(posicion + 1)}");
                Console.WriteLine($"Numero Habiatcino: {Numero[posicion]}");
                Console.WriteLine($"Precio: {Precio[posicion]}");
                Console.WriteLine($"Disponible: {Disponible[posicion]}");
                if (!Disponible[posicion])
                {
                    Console.WriteLine($"Cliente: {Cliente[posicion]}");
                }
                Console.WriteLine($"Numero de camas: {NumeroDeCamas[posicion]}");
            }
            else
            {
                Console.WriteLine("No se encuentra la habitación...");
            }
        }
        public void EliminarHabitacionSimple(int numeroHabitacion)
        {
            if (numeroHabitacion >= 0)
            {
                MostrarHabitacion(numeroHabitacion);
                Numero.RemoveAt(numeroHabitacion);
                Precio.RemoveAt(numeroHabitacion);
                Disponible.RemoveAt(numeroHabitacion);
                Cliente.RemoveAt(numeroHabitacion);
                NumeroDeCamas.RemoveAt(posicion);  // Elimina el dato específico de la clase hija
                Console.WriteLine("Habitación Simple Eliminada.");
            }
            else
            {
                Console.WriteLine("No se encuentra la habitacion...");
            }
        }

    }
}
