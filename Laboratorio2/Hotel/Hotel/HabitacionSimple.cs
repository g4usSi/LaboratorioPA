using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel
{
    internal class HabitacionSimple : Habitacion
    {
        public List<int> NumeroDeCamas { get; set; } = new List<int>();

        public void AgregarHabitacionSimple()
        {
            Console.WriteLine("\t\t\t> Habitacion Simple <");
            Console.Write($"Numero Habitacion: ");
            int numeroHabitacion = LlenarNumeroEntero();
            Console.Write($"Precio Habitacion: ");
            double precioHabitacion = LlenarNumeroDouble();
            Console.Write("Numero de camas: ");
            int numeroDeCamas = base.LlenarNumeroEntero();
            ListarHabitacionSimple(numeroHabitacion, precioHabitacion, numeroDeCamas);
            Console.WriteLine("Habitacion simple agregada con exito...");
        }
        public void ListarHabitacionSimple(int numero, double precio ,int numeroDeCamas)
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
            Console.WriteLine();
            Console.WriteLine("\t\t\t   Habitaciones Simples");
            for (int i = 0; i < NumeroDeCamas.Count; i++)
            {
                Console.WriteLine($"\t\tHabitacion #{i + 1}");
                Console.WriteLine($"Numero Habitacion: {Numero[i]}");
                Console.WriteLine($"Precio Habitacion: {Precio[i]}");
                Console.WriteLine($"Disponible: {Disponible[i]}");
                if (Disponible[i] == false)
                {
                    Console.WriteLine($"Cliente Asignado: {Cliente[i]}");
                }
                Console.WriteLine($"Numero de camas: {NumeroDeCamas[i]}");
            }
            Console.WriteLine();
        }
        public void MostrarHabitacionSimple(int posicion)
        {
            if (posicion >= 0)
            {
                Console.WriteLine("\t\t\tHabitacion Simple #"+posicion);
                //int posicion = base.RetornoPosicion(numeroHabitacion);
                Console.WriteLine($"\t\tHabitacion: #{(posicion + 1)}");
                Console.WriteLine($"Numero Habitacion: {Numero[posicion]}");
                Console.WriteLine($"Precio: {Precio[posicion]}");
                Console.WriteLine($"Disponible: {Disponible[posicion]}");
                if (!Disponible[posicion])
                {
                    Console.WriteLine($"Cliente: {Cliente[posicion]}");
                }
                Console.WriteLine($"Numero de camas: {NumeroDeCamas[posicion]}");
            }
        }
        public void EliminarHabitacionSimple(int numeroHabitacion)
        {
            if (numeroHabitacion >= 0)
            {
                MostrarHabitacionSimple(numeroHabitacion);
                Console.Write("> Esta segur@ que desea eliminar la habitacion: "+(numeroHabitacion+1)+"?\n(Si/No) no se puede deshacer: ");
                string confirmacion = Console.ReadLine().ToLower();
                if (confirmacion=="Si"||confirmacion=="s") 
                {
                    Numero.RemoveAt(numeroHabitacion);
                    Precio.RemoveAt(numeroHabitacion);
                    Disponible.RemoveAt(numeroHabitacion);
                    Cliente.RemoveAt(numeroHabitacion);
                    NumeroDeCamas.RemoveAt(numeroHabitacion);  // Elimina el dato específico de la clase hija
                    Console.WriteLine("Habitación Simple Eliminada.\n> Enter para continuar");
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