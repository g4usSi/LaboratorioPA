using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class ClienteVIP:Cliente
    {
        public ClienteVIP(string nombre, string correo, string direccion, double descuento)
            :base(nombre, correo, direccion)
        {
            this.Descuento = 0.15;
        }
        public override void RegistrarCliente()
        {
            Console.WriteLine("\t\t\t> Nuevo Cliente VIP <");
            base.RegistrarCliente();
        }
        public override void MostrarInformacionCliente()
        {
            base.MostrarInformacionCliente();
            Console.WriteLine("Tipo de cliente: VIP");
        }
        public override void AplicarDescuento()
        {
            //Terminado
            Console.WriteLine($"[!] Cliente VIP descuento del: {(Descuento*100)}% aplicado...");
        }
    }
}