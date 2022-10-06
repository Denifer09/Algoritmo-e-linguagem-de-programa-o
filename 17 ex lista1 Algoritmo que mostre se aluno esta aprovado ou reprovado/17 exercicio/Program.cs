using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _17_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            string aluno;

            Console.WriteLine("digite o nome do aluno");
            aluno = Console.ReadLine();

            Console.WriteLine("digite a nota 1");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota 2");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota 3");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota 4");
            n4 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 5 && media <= 11)
            {
                Console.WriteLine("o aluno foi aprovado com media de " + media);
            }
            else if (media < 5 && media > 0)
            {
                Console.WriteLine("o aluno foi reprovado com media" + media);
            }
            else
            {
                Console.WriteLine("digite notas com valores de 0 a 10");
            }

            }

        }
    }
