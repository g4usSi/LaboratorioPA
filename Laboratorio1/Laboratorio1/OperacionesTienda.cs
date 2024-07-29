using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    internal class OperacionesTienda
    {
        /*
        public List<double> NombreProducto { get; set; }
        public List<double> Precio { get; set; }
        public OperacionesTienda (List<string> nombreProducto, List<double> precioProducto)
        {
            NombreProducto = new List<double>();
            precioProducto = new List<double>();
        }        
        */
        static int contadorProductos;
        static double PrecioProducto;
        static double Total;
        static string Producto;
        public void IngresarProductos() 
        {
            bool entrada = false;
            Console.Write("Ingrese el nombre del producto: ");
            Producto = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: Q ");
            do {

                try
                {
                    PrecioProducto = Convert.ToDouble(Console.ReadLine());
                    entrada = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Intente de nuevo: ");
                }
            } while (!entrada);
            contadorProductos++;
            SumarPrecios(PrecioProducto);
        }
        public double CalcularTotal() 
        { 
            return Total;
        }
        public double AplicarDescuento(double total)
        {
            if (total >= 500)
            {
                Console.WriteLine("Descuento del 15% aplicado sobre su total...");
                return total = total - (total * 0.15);
            }
            else 
            {
                return total;
            }
        }
        public void MostrarSubtotal() 
        {
            Console.WriteLine("Su carreta actual: Q "+Total);
        }
        public bool Continuar() 
        {
            Console.WriteLine("Desea continuar agregando productos (si/no): ");
            string continuar = Console.ReadLine();
            if (continuar == "si" || continuar == "s")
            {
                return true;
            }
            else 
            { 
                return false;
            }

        }
        public void SumarPrecios(double precioActual) 
        {
            Total += precioActual;
        }
        public void MostrarTotal() 
        {
            Console.WriteLine("El total de su compra es: Q"+AplicarDescuento(Total));
        }
    }
}