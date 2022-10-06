using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, media;
            string aluno;

            Console.WriteLine("Digite o nome do aluno ");
            aluno = Console.ReadLine();

            Console.WriteLine("Digite a nota 1 : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2 : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3 : ");
            n3 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("A nota 1 é : " +n1);
            Console.WriteLine("A nota 2 é : " +n2);
            Console.WriteLine("A nota 3 é : " +n3);
            Console.WriteLine("A media de "+aluno+ " é " +media);


        }
    }
}
