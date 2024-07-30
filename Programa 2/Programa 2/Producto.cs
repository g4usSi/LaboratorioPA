using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{
    internal class Producto
    {
        public List<string> Nombre { get; set; }
        public List<double> Precio { get; set; }
        public List<int> Stock { get; set; }
        public Producto()
        { }


        public void MostrarInformacionProducto() {
            
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: Q{Precio}");
            Console.WriteLine($"Precio: Q{Stock}");
        }
        public void VenderProducto(int cantidadVendida) { 
            Stock -= cantidadVendida;
        }
        public void ReestablecerStock(int cantidadReestablecida) {
            Stock += cantidadReestablecida;
        }



    }
}
