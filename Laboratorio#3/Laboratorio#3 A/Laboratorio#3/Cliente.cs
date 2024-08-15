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
        public double Descuento { get; set; }
        public Cliente() { }
        public Cliente(string nombre, string correo, string direccion)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Descuento = 0;
        }
        public virtual void RegistrarCliente()
        {
            Console.WriteLine("\t\t\tRegistrar un nuevo cliente");
            Console.Write("Ingrese el nombre del cliente:");
            this.Nombre = LlenarString();
            Console.Write("Ingrese el correo del cliente:");
            this.Correo = LlenarString();
            Console.Write("Ingrese la dirección del cliente:");
            this.Direccion = LlenarString();
        }
        public virtual void MostrarInformacionCliente()
        {
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Direccion: {Direccion}");
        }
        public virtual void AplicarDescuento() 
        {
               
        }
        //Metodos basicos de interaccion de usuario
        public string LlenarString()
        {
            string cadena;
            bool continuar = true;
            while (!continuar)
            {
                cadena = Console.ReadLine();
                if (!string.IsNullOrEmpty(cadena))
                {
                    continuar = false;
                    return cadena;
                }
                else
                {
                    Console.WriteLine("[!] No puede ingresar datos vacios...");
                    Console.Write("Intente de nuevo: ");
                }
            }
            return string.Empty;
        }
        public int LlenarNumeroEntero()
        {
            int numeroEntero = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    while (numeroEntero <= 0)
                    {
                        numeroEntero = Convert.ToInt32(Console.ReadLine());
                        if (numeroEntero < 0)
                        {
                            Console.Write("No puede ingresar numeros negativos...\nIntente de nuevo: ");
                        }
                        valido = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("> Intente de nuevo: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[!] Error desconocido... " + ex+"\n");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroEntero;
        }
        public double LlenarNumeroDouble()
        {
            double numeroDouble = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    numeroDouble = Convert.ToDouble(Console.ReadLine());
                    valido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("> Intente de nuevo: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[!] Error desconocido... " + ex+"\n");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroDouble;
        }

    }
}
