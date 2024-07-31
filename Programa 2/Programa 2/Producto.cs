using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{

    internal class Producto
    { 
    static int Cantidad;
    static double Valor;
        //los atributos no inician el tipo de dato
        public List<string> Nombre { get; set; }
        public List<double> Precio { get; set; }
        public List<int> Stock { get; set; }
        //el constructor es este... y si inicializa el tipo de dato, lista
        public Producto()
        {
            Nombre = new List<string>();
            Precio = new List<double>();
            Stock = new List<int>();
        }

        public void AgregarProducto(string nombre, double precio, int stock)
        {
                Nombre.Add(nombre);
                Precio.Add(precio);
                Stock.Add(stock);
            Console.WriteLine("Producto agregado exitosamente");
        }
        public int BuscarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombreIngresado = Console.ReadLine();
            for (int i = 0; i < Stock.Count; i++)
            {
                if (Nombre[i].Equals(nombreIngresado))
                {
                    return i;
                }
            }
            return -1;
        }
        public void MostrarInformacionProducto()
        {
            int posicion = BuscarProducto();
            if (posicion >= 0)
            {
                Console.WriteLine($"Nombre: {Nombre[posicion]}");
                Console.WriteLine($"Precio: Q{Precio[posicion]}");
                Console.WriteLine($"Stock: {Stock[posicion]}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public void VenderProducto() 
        {

            int posicion = BuscarProducto();
            Console.WriteLine("Stock Actual: " + Stock[posicion]);
            Console.Write("Ingrese la cantidad que desea adquirir: ");
            int cantidadVendida = LlenarNumeroEntero();
            if (posicion >= 0)
            {
                Stock[posicion] -= cantidadVendida;
                Console.WriteLine("Stock actualizado correctamente: "+ Stock[posicion]);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public void ReestablecerStock()
        {
            int posicion = BuscarProducto();
            Console.WriteLine("Stock Actual: " + Stock[posicion]);
            Console.Write("Ingrese la cantidad que desea reestablecer: ");
            int cantidadReestablecida = LlenarNumeroEntero();
            if (posicion >= 0)
            {
                Stock[posicion] += cantidadReestablecida;
                Console.WriteLine("Stock actualizado correctamente: " + Stock[posicion]);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public void ActualizarPrecioProducto()  
        {
            int posicion = BuscarProducto();
            Console.Write("Ingrese el nuevo precio que desea actualizar el producto: ");
            double cantidadActualizada = LlenarValor();
            if (posicion >= 0)
            {

                Precio[posicion] = cantidadActualizada;
                Console.WriteLine("Precio actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        //Llenar numeros
        public int LlenarNumeroEntero()
        {//Llenar numero
            bool valido = false;
            while (!valido)
            {
                try
                {
                    Cantidad = Convert.ToInt32(Console.ReadLine());
                    //se ejecuta linea por linea si hay una excepcion se captura antes del bool
                    valido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("Intente de nuevo: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("[!] Error desconocido... ");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return Cantidad;
        }
        public double LlenarValor()
        {//Llenar numero
            bool valido = false;
            while (!valido)
            {
                try
                {
                    Valor = Convert.ToDouble(Console.ReadLine());
                    //se ejecuta linea por linea si hay una excepcion se captura antes del bool
                    valido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("Intente de nuevo: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("[!] Error desconocido... ");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return Valor;
        }
    }
}
