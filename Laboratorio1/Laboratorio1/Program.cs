using Laboratorio1;

OperacionesTienda operaciones = new OperacionesTienda();
Console.WriteLine("...  Tienda en Linea ...");
do {
    operaciones.IngresarProductos();
    operaciones.MostrarSubtotal();
} while (operaciones.Continuar());
Console.WriteLine();
operaciones.MostrarTotal();