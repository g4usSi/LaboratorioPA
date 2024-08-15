using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class ClienteCorporativo : Cliente
    {
        //cambiar a vehiculo corporativo, y con un if, asociar los vehiculos corpo
        public List<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
        public ClienteCorporativo(string nombre, string correo, string direccion)
            : base(nombre, correo, direccion)
        {
            this.Descuento = 0.25;
        }
        public override void RegistrarCliente()
        {
            Console.WriteLine("\t\t\t> Nuevo cliente corporativo <");
            base.RegistrarCliente();
        }
        public override void MostrarInformacionCliente()
        {
            base.MostrarInformacionCliente();
            Console.WriteLine("Tipo de cliente: Corporativo");
            Console.WriteLine("Vehiculos asignados:");
            //imprimir los atributos de vehiculos, y sobrecargar metodos, por cada vehiculo
            foreach (var vehiculo in Vehiculos)
            {
                Console.WriteLine();
            }
        }
        public ClienteCorporativo() { }

    }
}
