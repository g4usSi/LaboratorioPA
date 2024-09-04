using Laboratorio5;
    public class Program
    {
        public static void Main(string[] args)
        {
            int idTarea = 1;
            Tarea administrador = new Tarea();
            List<Tarea> listaTareas = new List<Tarea>();
            int opcion = 0;
            bool salir = false;
            do
            {
                Menu();
                Console.Write("\n  > Ingresa una opcion: ");
                switch (opcion = Utilidades.LlenarNumeroEntero())
                {
                    case 1:
                        Console.Clear();
                        Utilidades.TituloMensaje("\t\t░░░░░░░░░░░░ AGREGAR TAREA ░░░░░░░░░░░░");
                        Console.WriteLine();
                        Tarea nuevaTarea = new Tarea();
                        nuevaTarea.RegistrarTarea(idTarea);
                        listaTareas.Add(nuevaTarea);
                        idTarea++;
                        Utilidades.TituloMensaje("\t\t\tTarea agregada con exito");
                        Utilidades.EsperaConfirmacion();
                      
                        break;
                    case 2:
                        Console.Clear();
                        Utilidades.TituloMensaje("\t\t░░░░░░░░░░░░ TODAS LAS TAREAS ░░░░░░░░░░░░");
                        administrador.MostrarTareas(listaTareas);
                        Utilidades.EsperaConfirmacion();
                        break;
                    case 3:
                        Console.Clear();
                        Utilidades.TituloMensaje("\t\t░░░░░░░░░░░░ MARCAR UNA TAREA ░░░░░░░░░░░░");
                        administrador.MarcarTarea(listaTareas);
                        
                        break;
                    case 4:
                        Console.Clear();
                        Utilidades.TituloMensaje("\t\t░░░░░░░░░░░░ SALIR ░░░░░░░░░░░░");
                        Console.WriteLine("[!] Los datos del programa se eliminaran...");
                        salir = Utilidades.TerminarEjecucion();
                        break;
                    default:
                        Console.Clear();
                        Utilidades.ErrorMensaje("Opcion Incorrecta...\n> > > Regresando al menu...\n");
                        break;
                }
            } while (!salir);

            static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t  STICKY NOTES");
                Console.WriteLine("\t░░░░░░░░░░░░░░░░ Menu Principal ░░░░░░░░░░░░░░░░");
                Console.ResetColor();
                Console.WriteLine("\n1. Añadir Tarea");
                Console.WriteLine("2. Ver todas las tareas");
                Console.WriteLine("3. Marcar tarea como completa");
                Console.WriteLine("4. Salir");
            }
        }
    }
