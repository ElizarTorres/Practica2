using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            String Ciudad;

            Console.Beep();
            Console.WriteLine("¿Cuál es tu nombre?");
            Nombre = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Beep();
            Console.WriteLine("Oh, ¿y en que ciudad estás?");
            Ciudad = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Beep();
            Console.WriteLine("Así que tu nombre es " + Nombre + " y eres de " + Ciudad + ".\nCuando presiones una tecla terminará esta corta charla, ¡fue un gusto!");
            Console.ReadKey();
        }
    }
}
