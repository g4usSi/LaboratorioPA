using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class Tarea
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public Tarea() { }
        public void RegistrarTarea(int idTarea) 
        {
            this.ID = idTarea;
            Console.Write("   Escribe el nombre de la tarea: ");
            this.Nombre = Utilidades.LlenarString();
            Console.WriteLine("   Descripcion de la tarea: ");
            Console.Write("\t> ");
            this.Descripcion = Utilidades.LlenarString();
            this.Estado = false;
        }
        public void MostrarTarea() 
        {
            Console.WriteLine($" Numero de Tarea: #{ID}");
            Console.WriteLine($" Estado: {Utilidades.Enmascarado(Estado)}");
            Console.ResetColor();
            Console.WriteLine($" Descripcion: ");
            Console.Write($"\t- {Descripcion}");
        }
        public void MostrarTareas(List<Tarea> listaTareas) 
        {
            if (listaTareas.Count > 0) {
                int numeroTarea = 1;
                foreach (var tareaActual in listaTareas)
                {
                    Utilidades.TituloMensaje("\t\t\t» Tarea: " + tareaActual.Nombre+ " «");
                    tareaActual.MostrarTarea();
                    Console.WriteLine();
                    numeroTarea++;
                }
            }
            else 
            {
                Utilidades.ErrorMensaje("Aun no hay tareas agregadas");
            }
        }
        public void MarcarTarea(List<Tarea> listaTarea) 
        {
            Console.WriteLine();
            Console.Write("Ingrese el numero de la tarea: ");
            int numeroTarea = Utilidades.LlenarNumeroEntero();
            Tarea tareaBuscada = BuscarTarea(listaTarea, numeroTarea);
            if (tareaBuscada != null)
            {
                if (tareaBuscada.Estado == false)
                {
                    tareaBuscada.Estado = true;
                    Console.WriteLine($"La tarea: ( {tareaBuscada.Nombre} ), se marco como completada...");
                    Console.WriteLine("\t\tSigue asi :)");
                    Utilidades.EsperaConfirmacion();
                }
                else 
                {
                    Console.WriteLine("[!] Esta tarea ya fue completada...");
                    CambiarEstadoUsuario(tareaBuscada);
                    Utilidades.EsperaConfirmacion();
                }
            }
            else 
            {
                Console.WriteLine("[!] No hay coincidencias");
                Utilidades.EsperaConfirmacion();
                Console.WriteLine(" > > > Regresando al menu...");
            }

        }
        public void CambiarEstadoUsuario(Tarea tareaBuscada) 
        {
            Console.Write("Deseas cambiar su estado? (si/no): ");
            string cambio = Console.ReadLine().ToLower();
            if ((cambio == "s" || cambio == "si"))
            {
                tareaBuscada.Estado = false;
                Utilidades.TituloMensaje("Se ha cambiado el estado de la tarea...");
            }
            else 
            {
                Utilidades.ErrorMensaje("No se ha cambiado el estado de la tarea...");
                Console.WriteLine();
                return;
                
            }

        }
        private Tarea BuscarTarea(List<Tarea> listaTareas, int numeroTarea) 
        {
            foreach (var tareaActual in listaTareas) 
            {
                if (tareaActual.ID == numeroTarea)
                { 
                    return tareaActual;
                }
            }
            return null;
        }

    }
}
