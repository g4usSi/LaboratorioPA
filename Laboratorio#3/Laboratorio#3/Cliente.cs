using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; }

        public Cliente() { }

        public Cliente(string nombre, string correo, string direccion)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.Direccion = direccion;
        }
        public virtual void MostrarInformacion() 
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Direccion: {Direccion}");
            Console.WriteLine($"Tipo cliente: {Tipo}");
        }
        public virtual void AgregarCliente() 
        {
            this.Nombre = Console.ReadLine();
            this.Correo = Console.ReadLine();
            this.Direccion = Console.ReadLine();
        }



    }
}
