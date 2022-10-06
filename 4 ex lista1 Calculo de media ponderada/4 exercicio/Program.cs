using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _4_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, media, pesoN;
            string nome;
            
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            
            Console.WriteLine("digite a nota n1");h
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota n2");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota n3");
            n3 = int.Parse(Console.ReadLine());

            pesoN = (n1 * 2) + (n2 * 4) + (n3 * 6);
            media = pesoN / 12;

            Console.WriteLine("a media é ");
            Console.WriteLine(media);
        }
    }
}
