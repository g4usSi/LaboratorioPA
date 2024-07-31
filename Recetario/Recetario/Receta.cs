using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario
{

    internal class Receta
    {
        static int Cantidad;
        public List<string> Nombre { get; set; }
        public List<string> Descripcion { get; set; }
        public List<double> Tiempo { get; set; }
        public Receta()
        {
            Nombre = new List<string>();
            Descripcion = new List<string>();
            Tiempo = new List<double>();
        }
        public void AgregarReceta(string nombre, string descripcion, double tiempo)
        {
            Nombre.Add(nombre);
            Descripcion.Add(descripcion);
            Tiempo.Add(tiempo);
            Console.WriteLine("Receta agregada exitosamente...");
            Console.WriteLine();
        }
        public int BuscarReceta()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombreIngresado = Console.ReadLine();
            for (int i = 0; i < Tiempo.Count; i++)
            {
                if (Nombre[i].Equals(nombreIngresado))
                {
                    return i;
                }
            }
            return -1;
        }
        public void MostrarReceta(int posicion) 
        {
            if (posicion >= 0)
            {
                Console.WriteLine();
                Console.WriteLine($"\t\tNombre: {Nombre[posicion]}");
                Console.WriteLine($"Tiempo de Coccion: {Tiempo[posicion]} mins");
                Console.WriteLine($"\t\tDescripcion: \n{Descripcion[posicion]}");
            }
            else 
            {
                Console.WriteLine("La receta no existe...");
            }
        }
        public void MostrarRecetas()
        {
            Console.WriteLine();
            for (int i = 0; i < Nombre.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"\t\tNombre: {Nombre[i]}");
                Console.WriteLine($"Tiempo de Coccion: {Tiempo[i]} mins");
                Console.WriteLine($"\t\tDescripcion: \n{Descripcion[i]}");
            }
        }
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
    }
}
