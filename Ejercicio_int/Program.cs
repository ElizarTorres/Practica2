using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_int
{
    class Program
    {
        //Crear tres variables de tipo INT y asignarles valores estáticos.
        //Crear una variable de tipo INT la cual guardará la suma de las 3 viariables anteriores.
        //Mostrar en pantalla el valor de suma, con el siguiente mensaje: "El valor de la suma es: <suma>"
        static void Main(string[] args)
        {
            int x = 35;
            int y = 22;
            int z = 10;
            int suma;

            suma = x + y + z;

            Console.WriteLine("El valor de la suma es: " + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
