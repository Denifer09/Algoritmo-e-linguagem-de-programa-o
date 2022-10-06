using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite c");
            c = int.Parse(Console.ReadLine());

            if (a < b && b < c)
            {
                Console.WriteLine("A sequencia crescente dos numeros digitados são : ");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else if (b <c && c < a)
            {
                Console.WriteLine("A sequencia crescente dos numeros digitados são : ");
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
            else if (c <a && a< b)
            {
                Console.WriteLine("A sequencia crescente dos numeros digitados são : ");
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else if (b< a && a < c)
            {
                Console.WriteLine("A sequencia crescente dos numeros digitados são : ");
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else if (c<b && b <a)
            {
                Console.WriteLine("A sequencia crescente dos numeros digitados são : "+c++ b++a);
                
            }
            else if (a<c && c<b)
            {
                Console.WriteLine("A sequencia crescente dos numeros digitados são : ");
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        }
}
