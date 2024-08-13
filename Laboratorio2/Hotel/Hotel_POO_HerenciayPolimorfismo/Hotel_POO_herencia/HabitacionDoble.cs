using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_POO_herencia
{
    internal class HabitacionDoble:Habitacion
    {
        public HabitacionDoble() { }
        public bool VistaAlMar { get; set; }
        public HabitacionDoble(int numeroHabitacion, double precioHabitacion, bool disponible, string clienteAsignado, bool vistaAlMar)
            : base(numeroHabitacion, precioHabitacion, disponible, clienteAsignado)
        {
            this.VistaAlMar = vistaAlMar;
        }

        public override void AgregarHabitacion()
        {
            Console.WriteLine("\n\t\t\t> Agregar una habitacion doble <");
            base.AgregarHabitacion();
            Console.Write("Tiene vista al mar? (Si/No): ");
            string vistaMar = Console.ReadLine().ToLower();
            this.VistaAlMar = (vistaMar == "si" || vistaMar == "s");
        }
        public override void MostrarHabitacionUnica(Habitacion habitacion)
        {
            base.MostrarHabitacionUnica(habitacion);
            if (habitacion is HabitacionDoble habitacionSimple)
            {
                Console.WriteLine($"Vista al mar: {EnmascaradoTiene(habitacionSimple.VistaAlMar)}");
                Console.WriteLine("Tipo de habitacion: Doble");
            }
            Console.WriteLine();
        }
    }
}
