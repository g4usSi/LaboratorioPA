using Laboratorio1;

List<string> productos = new List<string>();
List<double> precio = new List<double>();
OperacionesTienda operaciones = new OperacionesTienda();
Console.WriteLine("...  Tienda en Linea ...");
do {
    operaciones.IngresarProductos();
    operaciones.MostrarSubtotal();
} while (operaciones.Continuar());