using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xn, xerox_inteira, xerox_desconto; 
            

            Console.WriteLine("digite o numero de xerox ");
            xn = double.Parse(Console.ReadLine());


            xerox_inteira = (xn * 0.50);

            xerox_desconto = (xn * 0.30);

            if (xn >= 200)
            {
                Console.WriteLine("o valor a ser pago é " + xerox_desconto);
            }
            else
            {
                Console.WriteLine("o valor a pagar é " + xerox_inteira);
            }
            

           
        }
    }
}
