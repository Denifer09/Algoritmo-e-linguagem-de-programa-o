using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            y = 200;
            z = 300;

            Console.WriteLine("Digite o valor de x");
            x = int.Parse(Console.ReadLine());

            if (x >= y && x <= z)
            {
                Console.WriteLine("O valor de x esta entre 200 e 300");
            }
            else
            {
                Console.WriteLine("O valor de x não esta entre 200 e 300");
            }

        }
        }
    }

