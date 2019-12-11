using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vellonera
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList listanueva = new LinkedList();
            Console.ReadKey();
            ConsoleKeyInfo option;
            int posicion = 1;
            int repeat = 0;
            string repeticion = " ";
            do
            {
                if (repeat == 1)
                {
                    repeticion = "Desactivar Repeticion en lista ";
                }
                else
                {
                    repeticion = "Activar Repeticion en lista ";
                }
                Console.Clear();

                Console.WriteLine("Bienvenidos al sistema de vellonera...");
                Console.WriteLine("[A]Agregar Nueva Cancion ");
                Console.WriteLine("[B]Mostrar Anterior");
                Console.WriteLine("[C]Mostrar Actual");
                Console.WriteLine("[D]Mostrar Siguiente");
                Console.WriteLine("[E]Visualizar canciones");
                Console.WriteLine("[F]Eliminar");
                Console.WriteLine("[G]"+repeticion);
                Console.WriteLine("[H]Salir");
                Console.Write("Seleccione opcion: ");
                option = Console.ReadKey(true);
                switch (option.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.Write("Escribe el nombre de la cancion: ");
                        string cancion = Console.ReadLine();
                        Console.Write("Escribe el nombre de el artista: ");
                        string artista = Console.ReadLine();
                        Console.Write("Escribe la duracion: ");
                        string duracion = Console.ReadLine();
                        string datos_cancion = cancion + ", " + artista + " " + duracion;
                        listanueva.InsertarF(datos_cancion);

                        break;
                    case ConsoleKey.B:
                        Console.Clear(); posicion--;
                        listanueva.mostraranterior();

                        Console.ReadKey();

                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        listanueva.mostraractual();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D:
                        Console.Clear(); posicion++;
                        listanueva.mostrarsiguiente();

                        Console.ReadKey();

                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        listanueva.mostrar();
                        Console.ReadKey();

                        break;
                    case ConsoleKey.F:
                        Console.Clear();
                        Console.WriteLine("Introduzca el numero de la cancion que desea eliminar:");
                        listanueva.mostrar();
                        string numero = Console.ReadLine();
                        int numero1 = int.Parse(numero);
                        listanueva.EliminarF(numero1);
                        Console.ReadKey();

                        break;
                    case ConsoleKey.G:
                        Console.Clear();

                        listanueva.repeticion();
                        Console.ReadKey();
                        if (repeat == 0) { repeat = 1; } else { repeat = 0; }
                        break;
                }
            } while (option.Key != ConsoleKey.H);
        }
    }
}
