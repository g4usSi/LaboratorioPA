using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_POO_herencia
{
    internal class Suite : Habitacion
    {
        public int Habitaciones { get; set; }
        public bool Jacuzzi { get; set; }
        public Suite(int numeroHabitacion, double precioHabitacion, bool disponible, string clienteAsignado, int numeroDeHabitaciones, bool jacuzzi)
            : base(numeroHabitacion, precioHabitacion, disponible, clienteAsignado)
        {
            this.Habitaciones = numeroDeHabitaciones;
            this.Jacuzzi = jacuzzi;
        }
        public Suite()
        {
            
        }
        public override void AgregarHabitacion()
        {
            Console.WriteLine("\n\t\t\t> Agregar una habitacion simple <");
            base.AgregarHabitacion();
            Console.Write("Numero de habitaciones: ");
            this.Habitaciones = LlenarNumeroEntero();
            Console.Write("Tiene Jacuzzi (Si/No): ");
            string jacuzzi = Console.ReadLine().ToLower();
            this.Jacuzzi = (jacuzzi == "si"||jacuzzi == "s");
        }
        public override void MostrarHabitacionUnica(Habitacion habitacion)
        {
            base.MostrarHabitacionUnica(habitacion);
            if (habitacion is Suite habitacionSuite)
            {
                Console.WriteLine($"Número de habitaciones: {habitacionSuite.Habitaciones}");
                Console.WriteLine($"Tiene Jacuzzi: {EnmascaradoTiene(habitacionSuite.Jacuzzi)}");
                Console.WriteLine("Tipo de habitacion: Suite");
            }
            Console.WriteLine();
        }

    }
}
