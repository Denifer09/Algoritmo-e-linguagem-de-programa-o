using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite a idade do jogador");

            idade = int.Parse(Console.ReadLine());

            if (idade <= 13)
            {
                Console.WriteLine("o jogador é infantil");
            }
            else if (idade>=14 && idade <=17)
            {
                Console.WriteLine("o jogador é juvenil");
            }
            else if (idade>=18)
            {
                Console.WriteLine("o jogador é senior");
            }


        }
    }
}
