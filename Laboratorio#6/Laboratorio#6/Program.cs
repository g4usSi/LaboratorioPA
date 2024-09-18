Console.WriteLine("Laboratorio #6");
Console.WriteLine("");

bool exit = false;
int opcion = 0;
int numeroUsuario = 0;
do
{
    Menu();
    Console.Write("Ingrese una opcion: ");
    switch (opcion = Utilidades.LlenarNumeroEntero()) 
    {
        case 1:
            Utilidades.TituloMensaje("\t\t*** FACTORIAL DE UN NUMERO ***");
            numeroUsuario = NumeroUsuario();
            Utilidades.TituloMensaje("\t\tITERACIONES");
            Utilidades.TituloMensaje("\t\tRRECURSIVIDAD");
            break;
        case 2:
            Utilidades.TituloMensaje("\t\tSERIE FIBONACCI");
            break;
        case 3:
            Utilidades.TituloMensaje("\t\tINGRESO DE DATOS");
            break;
        default:
            Console.WriteLine("");
        break;
    }

}
while (!exit);


static void Menu() 
{
    Utilidades.TituloMensaje("\t\tMenu Principal");
    Console.WriteLine("1. Factorial de un numero");
    Console.WriteLine("2. Serie fibonacci");
    Console.WriteLine("3. Ingreso de datos");
}
static int NumeroUsuario() 
{
    Console.WriteLine();
    Console.Write("Ingrese el numero para comenzar el programa:");
    int numeroUsuario = Utilidades.LlenarNumeroEntero();
    return numeroUsuario;
}

static int FactorialCiclo(int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}

static int Factorial(int n)
{
    if (n <= 1) //base para detenerlo
    {
        return n;
    }
    return n * Factorial(n - 1);
}