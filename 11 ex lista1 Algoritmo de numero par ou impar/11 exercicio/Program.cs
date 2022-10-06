using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.WriteLine("digite o numero");
            n1 = double.Parse(Console.ReadLine());


            if(n1%2== 0)
            {
                Console.WriteLine("o numero é par");
            }
            else
            {
                Console.WriteLine("o numero é impar");
            }
        }
    }
}
