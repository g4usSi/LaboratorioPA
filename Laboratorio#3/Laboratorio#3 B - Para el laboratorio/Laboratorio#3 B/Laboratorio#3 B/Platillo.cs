internal class Platillo
{
    public string NombrePlatillo { get; set; }
    public double PrecioPlatillo { get; set; }

    public Platillo(string nombrePlatillo, double precioPlatillo)
    {
        NombrePlatillo = nombrePlatillo;
        PrecioPlatillo = precioPlatillo;
    }
    public void MostrarPlatillo()
    {
        Console.WriteLine($"* Nombre platillo: {NombrePlatillo}\t\t* Precio: Q{PrecioPlatillo}");
    }
    public static void MostrarTodosPlatillos(List<Platillo> platillos)
    {
        Console.WriteLine("Platillos disponibles:");
        foreach (var platillo in platillos)
        {
            platillo.MostrarPlatillo();
        }
    }
    public static Platillo RetornarPlatillo(List<Platillo> listaPlatillos)
    {
        Console.Write("> Ingrese el nombre del platillo: ");
        string nombrePlatillo = Console.ReadLine();
        return listaPlatillos.FirstOrDefault(platillo => platillo.NombrePlatillo == nombrePlatillo);
    }
}
