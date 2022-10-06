using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tcelsius, Tfahrenheit;

            Console.WriteLine("Digite a temperatura em celcius : ");
            Tcelsius = int.Parse(Console.ReadLine());

            Tfahrenheit = (9 * Tcelsius + 160) / 5;

            Console.WriteLine("A temperatura em Fahrenheit é : " + Tfahrenheit);
        }
    }
}
