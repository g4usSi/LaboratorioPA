using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_POO_herencia
{
    internal class HabitacionSimple : Habitacion
    {
        public HabitacionSimple() { }
        public int NumeroDeCamas { get; set; }
        public HabitacionSimple(int numeroHabitacion, double precioHabitacion, bool disponible, string clienteAsignado, int numeroDeCamas)
            : base(numeroHabitacion, precioHabitacion, disponible, clienteAsignado)
        {
            this.NumeroDeCamas = numeroDeCamas;
        }

        public override void AgregarHabitacion()
        {
            Console.WriteLine("\n\t\t\t> Agregar una habitacion simple <");
            base.AgregarHabitacion();
            Console.Write("Numero de camas: ");
            this.NumeroDeCamas = LlenarNumeroEntero();
        }
        public override void MostrarHabitacionUnica(Habitacion habitacion)
        {
            base.MostrarHabitacionUnica(habitacion);
            if (habitacion is HabitacionSimple habitacionSimple)
            {
                Console.WriteLine($"Número de camas: {habitacionSimple.NumeroDeCamas}");
                Console.WriteLine("Tipo de habitacion: Simple");
            }
            Console.WriteLine();
        }


    }
}
