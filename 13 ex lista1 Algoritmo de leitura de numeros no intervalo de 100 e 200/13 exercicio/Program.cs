using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite o numero");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 100 && n1 <= 200)
            {
                Console.WriteLine("o numero esta entre 100 e 200 ");
            }
            else
            {
                Console.WriteLine("o numero não esta entre 100 e 200 ");
            }
        }
    }
}
