using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, A;
            Console.WriteLine("digite o valor de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor de B");
            b = double.Parse(Console.ReadLine());
            A = (a * b) / 2;
            Console.WriteLine("A area do triangulo é");
            Console.WriteLine(A);
        }
    }
}
