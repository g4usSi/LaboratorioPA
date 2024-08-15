using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_B
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
        }
        public Cliente BuscarCliente(List<Cliente> listaClientes)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string clienteBuscar = LlenarString();
            Cliente cliente = listaClientes.Find(c => c.Nombre.Equals(clienteBuscar, StringComparison.OrdinalIgnoreCase));
            if (cliente != null)
            {
                return cliente;
            }
            else
            {
                Console.WriteLine("[!] Cliente no encontrado.");
                return null;
            }
        }

        public virtual void RegistrarCliente()
        {
            Console.Write("> Ingrese el nombre del cliente: ");
            this.Nombre = LlenarString();
            Console.Write("> Ingrese el correo del cliente: ");
            this.Correo = LlenarString();
            Console.Write("> Ingrese la dirección del cliente: ");
            this.Direccion = LlenarString();
        }
        //alch
        public virtual void MostrarInformacionCliente(Cliente clienteActual)
        {
            Console.WriteLine($"Nombre: {clienteActual.Nombre}");
            Console.WriteLine($"Correo: {clienteActual.Correo}");
            Console.WriteLine($"Direccion: {clienteActual.Direccion}");
        }
        public virtual double AplicarDescuento(double total)
        {
            if (total >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\tCliente regular no se ha aplicado el descuento...");
                return total;
            }
        return total;

        }
        //Metodos basicos de interaccion de usuario
        public string LlenarString()
        {
            string cadena = string.Empty;
            bool valido = false;
            while (!valido)
            {
                cadena = Console.ReadLine();
                if (!string.IsNullOrEmpty(cadena))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("[!] No puede ingresar datos vacíos...");
                    Console.Write("Intente de nuevo: ");
                }
            }
            return cadena;
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
                    Console.WriteLine("[!] Error desconocido... " + ex + "\n");
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
                    Console.WriteLine("[!] Error desconocido... " + ex + "\n");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroDouble;
        }

    }
}
