using System;
using System.ComponentModel;

public class Producto
{
    public List<int> Numero { get; set; } = new List<int>();
    public List<double> Precio { get; set; } = new List<double>();
    public List<bool> Disponible { get; set; } = new List<bool>();
    public List<string> Cliente { get; set; } = new List<string>();
    public void MostrarHabitaciones()
    {
        for (int i = 0 ; i < Precio.Count ; i++)
        {
            Console.WriteLine($"\t\tProducto #{i}");
            Console.WriteLine($"Numero Habitacion: {Numero[i]}");
            Console.WriteLine($"Precio Habitacion: {Precio[i]}");
            Console.WriteLine($"Disponible: {Disponible[i]}");
            if (Disponible[i] == false)
            {
                Console.WriteLine($"Cliente Asignado: {Cliente[i]}");
                continue;
            }
        }
    }
    public void AgregarHabitacion(int numero, double precio, bool disponible, string cliente = "") 
    {
        Numero.Add(numero);
        Precio.Add(precio);
        Disponible.Add(disponible);
        Cliente.Add(cliente);
    }
    public int BuscarHabitacion(int numeroIngresado)
    {
        int posicion = Numero.IndexOf(numeroIngresado);
        return posicion;
    }
    public void MostrarHabitacion(int posicion)
    {
        if (posicion >= 0)
        {
            Console.WriteLine($"\t\tHabitacion: #{(posicion + 1)}");
            Console.WriteLine($"Numero Habiatcino: {Numero[posicion]}");
            Console.WriteLine($"Precio: {Precio[posicion]}");
            Console.WriteLine($"Disponible: {Disponible[posicion]}");
            if (Disponible[posicion])
            {
                Console.WriteLine($"Cliente: {Cliente[posicion]}");
            }
        }
        else 
        {
            Console.WriteLine("No se encontro la habitacion");
        }
    }
    public int LlenarNumeroEntero()
    {
        int numeroEntero = 0;
        bool valido = false;
        while (!valido)
        {
            try
            {
                numeroEntero = Convert.ToInt32(Console.ReadLine());
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
                Console.Write("Intente de nuevo: ");
            }
            catch (Exception)
            {
                Console.WriteLine("[!] Error desconocido... ");
                Console.Write("> Intente de nuevo: ");
            }
        }
        return numeroDouble;
    }


}
