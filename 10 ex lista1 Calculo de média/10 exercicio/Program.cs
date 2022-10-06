using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, media;

            Console.WriteLine("Digite n1");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite n2");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite n3");
            n3 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média dos valores é " + media);
        }
    }
}
