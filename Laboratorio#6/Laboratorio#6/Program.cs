using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Laboratorio #6");

bool exit = false;
int opcion = 0;
int numeroUsuario = 0;
do
{
    numeroUsuario = NumeroUsuario();
    Menu();
    switch (opcion = Utilidades.LlenarNumeroEntero()) 
    {
        case 1:
            Utilidades.TituloMensaje("\t*** FACTORIAL DE UN NUMERO ***");
            Utilidades.TituloMensaje("\t\tITERACIONES");
            Console.WriteLine("El factorial de (" + numeroUsuario + ") es: " + FactorialCiclo(numeroUsuario));
            Utilidades.TituloMensaje("\t\tRRECURSIVIDAD");
            Console.WriteLine("El factorial de (" + numeroUsuario + ") es: " + Factorial(numeroUsuario));
            Utilidades.EsperaConfirmacion();
            break;
        case 2:
            Utilidades.TituloMensaje("\t*** SERIE FIBONACCI ***");
            ImprimirSumaFibonacci(numeroUsuario);
            Utilidades.TituloMensaje("\t\tITERACIONES");
            Console.WriteLine("La posicion ( "+ numeroUsuario +" ) de la serie Fibonacci es: " + FibonacciCiclo(numeroUsuario));
            Utilidades.TituloMensaje("\t\tRRECURSIVIDAD");
            Console.WriteLine("La posicion ( "+ numeroUsuario +" ) de la serie Fibonacci es: " + Fibonacci(numeroUsuario));
            Utilidades.EsperaConfirmacion();
            break;
        case 3:
            int numEjemplo;
            Utilidades.TituloMensaje("\t*** INGRESO DE DATOS ***");
            Utilidades.TituloMensaje("\t\tITERACIONES");
            Console.WriteLine("> A continuacion ingrese un numero....");
            numEjemplo = LlenarNumeroEnteroCiclo();
            Console.WriteLine("\n [!] Numero ingresado: ( "+ numEjemplo +" ).");
            Utilidades.TituloMensaje("\t\tRRECURSIVIDAD");
            numEjemplo = LlenarNumeroEnteroRecursividad();
            Console.WriteLine("\n [!] Numero ingresado: ( " + numEjemplo + " ).");
            Utilidades.EsperaConfirmacion();
            break;
        case 4:
            Utilidades.TituloMensaje("SALIR");
            Console.WriteLine("Esta seguro que desea finalizar el programa? (si/no)");
            string exitString = Console.ReadLine().ToLower();
            exit = (exitString == "si"||exitString == "s");
            break;
        default:
            Console.Clear();
            Console.WriteLine("> > > Opcion incorrecta");
        break;
    }

}
while (!exit);


static void Menu() 
{
    Console.WriteLine();
    Utilidades.TituloMensaje("\t\tMenu Principal");
    Console.WriteLine("1. Factorial de un numero");
    Console.WriteLine("2. Serie fibonacci");
    Console.WriteLine("3. Ingreso de datos");
    Console.WriteLine("4. Salir");
    Console.Write("  > Ingrese una opcion: ");
}
static int NumeroUsuario() 
{
    Console.WriteLine();
    Console.Write("Ingrese el numero para comenzar el programa: ");
    int numeroUsuario = Utilidades.LlenarNumeroEntero();
    return numeroUsuario;
}
//Factorial
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

//Fibonacci
static int Fibonacci(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else if (n == 0)
    {
        return 0;
    }
    else
    {
        return Fibonacci(n - 2) + Fibonacci(n - 1);
    }
}
static void ImprimirSumaFibonacci(int n)
{
    int numeroAnterior = 0;
    int numeroPosterior = 1;
    Console.Write((numeroAnterior) + ", " + (numeroPosterior));
    for (int i = 2; i <= n; i++)
    {
        int suma = numeroAnterior + numeroPosterior;
        Console.Write(", " + suma);
        numeroAnterior = numeroPosterior;
        numeroPosterior = suma;
    }
    Console.WriteLine();
}
static int FibonacciCiclo(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {

        return 1;
    }
    int numeroAnterior = 0;
    int numeroPosterior = 1;
    int suma = 1;
    for (int i = 2; i <= n; i++)
    {
        suma = numeroAnterior + numeroPosterior;
        numeroAnterior = numeroPosterior;
        numeroPosterior = suma;
    }
    return suma;
}

//Ingreso de datos
static int LlenarNumeroEnteroCiclo()
{
    int numeroEntero = 0;
    bool valido = false;
    Console.WriteLine("-> Primer paso pedir el numero");
    Console.Write("Ingrese un numero entero: ");
    while (!valido)
    {
        try
        {
            numeroEntero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-> Ingreso al ciclo, si no se pudo convertir el numero, se repetira este ciclo while");
            if (numeroEntero > 0)
            {
                valido = true;
            }
            else
            {
                Console.Write("No puede ingresar números negativos o cero. \nIntente de nuevo: ");
            }
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[!] Error: no puede ingresar letras. \nIntente de nuevo: ");

        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[!] Error desconocido: " + ex.Message);
            Console.Write("Intente de nuevo: ");
        }
        finally
        {
            Console.ResetColor();
        }
    }
    return numeroEntero;
}

static int LlenarNumeroEnteroRecursividad()
{
    Console.WriteLine("-> Entrada al metodo\n");
    Console.Write("Ingrese un número entero: ");
    string entrada = Console.ReadLine();
    int numeroEntero;

    if (!int.TryParse(entrada, out numeroEntero))
    {
        Console.WriteLine("-> Entrada al caso base, si se cumple la funcion se llamara a si misma\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[!] Error: Debe ingresar un número entero válido.");
        Console.ResetColor();
        return LlenarNumeroEnteroRecursividad();
    }
    return numeroEntero;
}