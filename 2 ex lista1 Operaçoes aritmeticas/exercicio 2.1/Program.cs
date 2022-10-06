
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, multi, divi, soma, subt;
            Console.WriteLine("digite o valor de x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor de y");
            y = double.Parse(Console.ReadLine());
            multi = x * y;
            Console.WriteLine("A multiplicação de x e y é "+multi);
            divi = x / y;
            Console.WriteLine("A divisão de x e y é " +divi);
            soma = x + y;
            Console.WriteLine("A soma de x e y é " +soma);
            subt = x - y;
            Console.WriteLine("A subtração de x e y é " +subt);
        }
    }
}
