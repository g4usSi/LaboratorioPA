using System;
using System.ComponentModel;

public class Habitacion
{
    public List<int> Numero { get; set; } = new List<int>();
    public List<double> Precio { get; set; } = new List<double>();
    public List<bool> Disponible { get; set; } = new List<bool>();
    public List<string> Cliente { get; set; } = new List<string>();

    public void MostrarHabitaciones()
    {
        for (int i = 0; i < Precio.Count; i++)
        {
            Console.WriteLine($"\t\tHabitacion #{i + 1}");
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
    //Opcion 4
    public void AsignarHabitacion(int index)
    {
        if (index >= 0)
        {
            bool ocupado = Disponible[index];
            if (ocupado)
            {
                Console.WriteLine();
                Console.Write("> Ingrese el nombre del cliente: ");
                string nombreCliente = Console.ReadLine();
                Cliente[index] = nombreCliente;
                Disponible[index] = false;
                Console.WriteLine("Habitacion reservada a: " + nombreCliente);
            }
            else
            {
                Console.WriteLine("La habitacion ya esta ocupada");
            }
            Console.WriteLine("Regresando al menu...");
        }
    }
    //Opcion 5
    public void LiberarHabitacion(int index)
    {
        bool seguridad = false;
        if (index >= 0) 
        {
            bool ocupado = Disponible[index];
            if (!ocupado)
            {
                Console.WriteLine("Esta segur@ que desea liberar esta habitacion...");
                string confirmacion = Console.ReadLine().ToLower();
                seguridad = (confirmacion == "si" || confirmacion == "s");
                if (seguridad == true)
                {
                    Cliente[index] = "";
                    Disponible[index] = true;
                    Console.WriteLine("Se ha liberado la habitacion: " + (Numero[index]+1));
                }
                else
                {
                    Console.WriteLine("No se ha liberado la habitacion...\nRegresando al menu...");
                }
            }
            else
            {
                Console.WriteLine("La habitacion no esta ocupada...");
            }
        }
    }

    //Funcion solo para buscar una habitacion por numero
    public int BuscarHabitacion(int numeroHabitacion)
    {
        int posicion = Numero.IndexOf(numeroHabitacion);
        return posicion;
    }
    public int NumeroHabitacion()
    {
        Console.Write("Ingrese el numero de la habitacion: ");
        int numeroHabitacion = LlenarNumeroEntero();
        return numeroHabitacion;
    }
    //Metodos de interaccion Menu
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
                    if (numeroEntero <= 0)
                    {
                        Console.Write("No puede ingresar numeros negativos...\nIntente de nuevo: ");
                    }
                    valido = true;
                }
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
                Console.Write("> Intente de nuevo: ");
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