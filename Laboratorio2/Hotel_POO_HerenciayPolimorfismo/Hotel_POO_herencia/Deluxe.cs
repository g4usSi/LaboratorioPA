using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_POO_herencia
{
    internal class Deluxe : Habitacion
    {
        public string ServiciosExtra { get; set; }
        public Deluxe(int numeroHabitacion, double precioHabitacion, bool disponible, string clienteAsignado, string serviciosExtra)
            : base(numeroHabitacion, precioHabitacion, disponible, clienteAsignado)
        {
            this.ServiciosExtra = serviciosExtra;
        }
        public Deluxe() { }
        public override void AgregarHabitacion()
        {
            Console.WriteLine("\n\t\t\t> Agregar una habitacion deluxe <");
            base.AgregarHabitacion();
            Console.Write("Numero de habitaciones: ");
            this.ServiciosExtra = Console.ReadLine();
        }
        public override void MostrarHabitacionUnica(Habitacion habitacion)
        {
            base.MostrarHabitacionUnica(habitacion);
            if (habitacion is Deluxe habitacionDeluxe)
            {
                Console.WriteLine($"Número de habitaciones: {habitacionDeluxe.ServiciosExtra}");
                Console.WriteLine("Tipo de habitacion: Deluxe");
            }
            Console.WriteLine();
        }

    }
}
