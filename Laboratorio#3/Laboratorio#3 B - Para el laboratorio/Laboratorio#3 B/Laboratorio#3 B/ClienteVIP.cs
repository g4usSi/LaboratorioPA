using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_B
{
    internal class ClienteVIP : Cliente
    {
        public ClienteVIP(string nombre, string correo, string direccion)
            : base(nombre, correo, direccion)
        {
            this.Descuento = 0.15;
        }
        public ClienteVIP()
        {
            this.Descuento = 0.15;
        }
        public override void RegistrarCliente()
        {
            Console.WriteLine("\t\t\t/// Nuevo Cliente VIP ///");
            base.RegistrarCliente();
        }
        public override void MostrarInformacionCliente(Cliente clienteActual)
        {
             base.MostrarInformacionCliente(clienteActual);
             Console.WriteLine("Tipo de cliente: VIP");
        }
        public override double AplicarDescuento(double Total)
        {
            Console.WriteLine();
             Console.WriteLine($"\t\t\t[!] Cliente VIP descuento del: {(Descuento * 100)}% aplicado...");
             return Math.Round((Total - (Total*Descuento)), 2);
        }  
    }
}
