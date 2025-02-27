﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel
{
    internal class HabitacionDoble : Habitacion
    {
        public List<bool> VistaAlMar { get; set; } = new List<bool>();
        public void AgregarHabitacionDoble()
        {
            Console.WriteLine("\t\t\t> Habitacion Doble <");
            Console.Write($"Numero Habitacion: ");
            int numeroHabitacion = LlenarNumeroEntero();
            Console.Write($"Precio Habitacion: ");
            double precioHabitacion = LlenarNumeroDouble();
            Console.Write("Tiene vista al Mar: ");
            string vista = Console.ReadLine().ToLower();
            bool vistaMar = (vista == "si"|| vista == "s");
            ListarHabitacionDoble(numeroHabitacion, precioHabitacion, vistaMar);
            Console.WriteLine("Habitacion simple agregada con exito...");
        }
        public void ListarHabitacionDoble(int numero, double precio, bool vistaMar)
        {
            bool disponible = true;
            string cliente = "";
            Numero.Add(numero);
            Precio.Add(precio);
            Disponible.Add(disponible);
            Cliente.Add(cliente);
            VistaAlMar.Add(vistaMar);
        }
        public void MostrarHabitacionesDobles()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t   Habitaciones Dobles");
            for (int i = 0; i < VistaAlMar.Count; i++)
            {
                Console.WriteLine($"\t\tHabitacion #{i + 1}");
                Console.WriteLine($"Numero Habitacion: {Numero[i]}");
                Console.WriteLine($"Precio Habitacion: {Precio[i]}");
                Console.WriteLine($"Disponible: {Disponible[i]}");
                if (Disponible[i] == false)
                {
                    Console.WriteLine($"Cliente Asignado: {Cliente[i]}");
                }
                Console.WriteLine($"Vista al mar: {VistaAlMar[i]}");
            }
            Console.WriteLine();
        }
        public void MostrarHabitacionDoble(int posicion)
        {
            if (posicion >= 0)
            {
                Console.WriteLine("\t\t\tHabitacion Doble #" + posicion);
                //int posicion = base.RetornoPosicion(numeroHabitacion);
                Console.WriteLine($"\t\tHabitacion: #{(posicion + 1)}");
                Console.WriteLine($"Numero Habitacion: {Numero[posicion]}");
                Console.WriteLine($"Precio: {Precio[posicion]}");
                Console.WriteLine($"Disponible: {Disponible[posicion]}");
                if (!Disponible[posicion])
                {
                    Console.WriteLine($"Cliente: {Cliente[posicion]}");
                }
                Console.WriteLine($"Vista al mar: {VistaAlMar[posicion]}");
            }
        }
        public void EliminarHabitacionDoble(int numeroHabitacion)
        {
            if (numeroHabitacion >= 0)
            {
                MostrarHabitacionDoble(numeroHabitacion);
                Console.Write("> Esta segur@ que desea eliminar la habitacion: " + (numeroHabitacion + 1) + "?\n(Si/No) no se puede deshacer: ");
                string confirmacion = Console.ReadLine().ToLower();
                if (confirmacion == "Si" || confirmacion == "s")
                {
                    Numero.RemoveAt(numeroHabitacion);
                    Precio.RemoveAt(numeroHabitacion);
                    Disponible.RemoveAt(numeroHabitacion);
                    Cliente.RemoveAt(numeroHabitacion);
                    VistaAlMar.RemoveAt(numeroHabitacion);
                    Console.WriteLine("Habitación Doble Eliminada.\n> Enter para continuar");
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