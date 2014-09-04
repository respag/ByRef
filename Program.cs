using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int x = 12;
            Cuadrado(x, ref res);
            Console.WriteLine("El cuadrado de {0} es {1}", x, res); 
        }

        private static void Cuadrado(int x, ref int res)
        {
            res = x * x;
        }
    }
}
