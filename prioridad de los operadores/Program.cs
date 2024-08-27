using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prioridad_de_los_operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prioridad de los operadores aritmeticos
            //Se pone el sufijo m para la division con decimales.
            decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1;
            Console.WriteLine("La respuesta es: {0}", respuesta);//11.5 valor correcto

            Console.WriteLine("La division de 5/4 es {0}", respuesta);
            Console.ReadLine();
        }
    }
}
