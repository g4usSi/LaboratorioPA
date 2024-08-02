﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POOyListasBiblioteca
{
    internal class Libro
    {
        public List<string> Nombre;
        public List<string> Autor;
        public List<int> Año;

        public Libro()
        {
            Nombre = new List<string>();
            Autor = new List<string>();
            Año = new List<int>();
        }
        public void AgregarLibro()
        {
            Console.Write("Ingrese el nombre del nuevo libro: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el autor: ");
            string autor = Console.ReadLine();
            Console.Write("Ingrese el año: ");
            int año = Convert.ToInt32(Console.ReadLine());
            if (nombre != "" && autor != "" && año > 1000 ) {
                Nombre.Add(nombre);
                Autor.Add(autor);
                Año.Add(año);
                Console.WriteLine("Libro agregado exitosamente");
            }
            else
            {
                Console.WriteLine("Uno de sus parametros no es correcto...");
            }
        }
        public int BuscarLibro(string nombre) {
            int posicion = Nombre.IndexOf(nombre);
            return posicion;
        }
        public void MostrarLibros() 
        {
            for(int i=0; i < Año.Count; i++) {
                Console.WriteLine("Nombre: " + Nombre[i]);
                Console.WriteLine("Autor: " + Autor[i]);
                Console.WriteLine("Año: " + Año[i]);
            }
        }
        public void EliminarLibro() {
            Console.WriteLine("Libros en la Biblioteca");
            MostrarLibros();
            Console.WriteLine("Ingrese el nombre del libro: ");
            string nombre = Console.ReadLine();
            int posicion = BuscarLibro(nombre);

            if (posicion >= 0) {
                Nombre.RemoveAt(posicion);
                Autor.RemoveAt(posicion);
                Año.RemoveAt(posicion);
                Console.WriteLine("El libro se ha eliminado de la biblioteca: ");
            }
            else 
            {
                Console.WriteLine("El libro no se ha encontrado...");
            }
        }       
        public void EditarLibro() 
            {
            Console.WriteLine("Libros en la Biblioteca");
            MostrarLibros();
            Console.WriteLine("Ingrese el nombre del libro: ");
            string nombre = Console.ReadLine();
            int posicion = BuscarLibro(nombre);
            if (posicion >= 0) {
                Nombre.RemoveAt(posicion);
                Autor.RemoveAt(posicion);
                Año.RemoveAt(posicion);
                Console.WriteLine("El libro se ha eliminado de la biblioteca: ");
                Console.WriteLine("Agregue el nuevo libro....");
                AgregarLibro();
            }
            else 
            {
                Console.WriteLine("El libro no se ha encontrado...");
            }

        }

    }
}
