using System;
using System.ComponentModel;

public class Producto
{
    public List<int> Numero { get; set; } = new List<int>();
    public List<double> Precio { get; set; } = new List<double>();
    public List<bool> Disponible { get; set; } = new List<bool>();
    public List<string> Cliente { get; set; } = new List<string>();
    //Opcion 3
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
    //Opcion 1
    public void AgregarHabitacion(int numero, double precio, bool disponible, string cliente = "") 
    {
        Numero.Add(numero);
        Precio.Add(precio);
        Disponible.Add(disponible);
        Cliente.Add(cliente);
    }
    //Opcion 2
    public void EliminarHabitacion() 
    { 
        int numeroHabitacion = BuscarHabitacion();
        if (numeroHabitacion >= 0)
        {
            MostrarHabitacion(numeroHabitacion);
            Numero.RemoveAt(numeroHabitacion);
            Precio.RemoveAt(numeroHabitacion);
            Disponible.RemoveAt(numeroHabitacion);
            Cliente.RemoveAt(numeroHabitacion);
            Console.WriteLine("Habitacion Eliminada");
        }
        else
        {
            Console.WriteLine("No se encuentra la habitacion...");
        }
    }
    //Opcion 4
    public void AsignarHabitacion() 
    {
        int index = BuscarHabitacion();
        if (!Ocupado(index))
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();
            Cliente[index] = nombreCliente;
            Disponible[index] = false;
        }
        else
        {
            Console.WriteLine("La habitacion ya esta ocupada");
        }
    }
    public void LiberarHabitacion()
    {
        int index = BuscarHabitacion();
        if (Ocupado(index))
        {
            Cliente[index] = "";
            Disponible[index] = true;
            Console.WriteLine("Se ha liberado la habitacion: "+Numero[index]);
        }
        else
        {
            Console.WriteLine("La habitacion no esta ocupada...");
        }
    }
    public int BuscarHabitacion()
    {
        Console.Write("Ingrese el numero de la habitacion: ");
        int numeroHabitacion = LlenarNumeroEntero();
        int posicion = Numero.IndexOf(numeroHabitacion);
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
            Console.WriteLine("No se encontro la habitacion...");
        }
    }
    public bool Ocupado(int posicion)
    {
        if (posicion >= 0)
        {
            return Disponible[posicion];
        }
        else
        {
            return false;
        }
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
