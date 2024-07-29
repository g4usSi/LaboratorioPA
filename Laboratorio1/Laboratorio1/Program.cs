using Laboratorio1;

List<string> productos = new List<string>();
List<double> precio = new List<double>();
OperacionesTienda operaciones = new OperacionesTienda();

do {
    Console.WriteLine("...  Tienda en Linea ...");
    Console.Write("Igrese Productos... ");

} while (operaciones.Continuar());