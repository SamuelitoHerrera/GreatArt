using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa para calcular el promedio de un alumno\n");
            Console.Write("11-SIIN-1-013\n");
            Console.Write("Samuel Herrera\n");

            int nota1, nota2, nota3;

            string linea;

            Console.Write("Ingrese la primer nota");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);

            Console.Write("Ingrese la segunda nota");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);

            Console.Write("Ingrese la tercera nota");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);

            int promedio;

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7)
            {
                Console.Write("promocionado");
            }
            else
            {
                Console.Write("reprobado");
            }
            Console.ReadKey();
        }
    }
}
