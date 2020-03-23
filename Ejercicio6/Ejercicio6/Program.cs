using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Ingrese un numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = (a + b) * (a - b);

            Console.WriteLine("Resultado: " + c);

            Console.ReadKey();
        }
    }
}
