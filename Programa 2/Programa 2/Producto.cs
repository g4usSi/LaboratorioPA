using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{
    internal class Producto
    { 
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
        public void VenderProducto(int cantidadVendida) 
        {
            int posicion = BuscarProducto();
            if (posicion >= 0)
            {
                Stock[posicion] -= cantidadVendida;
                Console.WriteLine("Stock actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public void ReestablecerStock(int cantidadReestablecida)
        {
            int posicion = BuscarProducto();
            if (posicion >= 0)
            {
                Stock[posicion] += cantidadReestablecida;
                Console.WriteLine("Stock actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public void ActualizarPrecioProducto(double cantidadActualizada) 
        {
            int posicion = BuscarProducto();
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
    }
}
