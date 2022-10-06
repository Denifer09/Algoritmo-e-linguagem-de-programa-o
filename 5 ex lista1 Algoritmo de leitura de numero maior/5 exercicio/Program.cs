using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            Console.WriteLine("digite o valor de x");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de y");
            y = int.Parse(Console.ReadLine());

            if (x >= y)
            {
                Console.WriteLine(" o nummero x é maior ou igual a y");
            }
            else
            {
                Console.WriteLine(" o numero y é maior ou igual a x");
            }
        }
    }
}
