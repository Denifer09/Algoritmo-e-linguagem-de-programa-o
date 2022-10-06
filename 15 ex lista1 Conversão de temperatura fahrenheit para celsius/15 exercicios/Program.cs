using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tcelsius, Tfahrenheit;

            Console.WriteLine("Digite a temperatura em Fahrenheit : ");
            Tfahrenheit = int.Parse(Console.ReadLine());

            Tcelsius = ((Tfahrenheit - 32) * 5) / 9;

            Console.WriteLine("A temperatura em Celcius é : " + Tcelsius);
        }
    }
}
