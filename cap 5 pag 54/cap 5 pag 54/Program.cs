﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cap_5_pag_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("digite o numero ");
            n1 = int.Parse(Console.ReadLine());

            while (n1<100)
            {
                n1++;
                Console.WriteLine(n1);
            }
        }
    }
}
