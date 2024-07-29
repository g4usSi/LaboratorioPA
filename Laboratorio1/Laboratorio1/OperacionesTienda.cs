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
        public double IngresarProductos() 
        { 
            
            contadorProductos++;
        }
        public double Total() 
        { 
            
        }
        public double Descuento()
        {

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
    }
}
