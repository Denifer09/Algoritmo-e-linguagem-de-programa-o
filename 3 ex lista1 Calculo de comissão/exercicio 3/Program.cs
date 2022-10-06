using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sfixo, tvmes, Porcen, sfinal;
            string nome;

            Console.WriteLine("Digite o nome do vendedor: ");
            nome = (Console.ReadLine());

            Console.WriteLine("digite o salario fixo do mes");
            sfixo = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o total de vendas do mes");
            tvmes = double.Parse(Console.ReadLine());

            Porcen = (tvmes / 100) * 20;

            Console.WriteLine("o salario fixo do : "+nome) ;
            Console.WriteLine(sfixo);
            Console.WriteLine("o total de vendas no mes é: ");
            Console.WriteLine(tvmes);
            Console.WriteLine("a comissao do vendedor é: ");
            Console.WriteLine(Porcen);

            
            sfinal = sfixo + Porcen;
            Console.WriteLine("O salario final é: ");
            Console.WriteLine(sfinal);

        }
    }
}
