using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo menos 12.
               Escreva um algoritmo que leia o número de maçãs compradas, calcule e escreva o custo total da compra */
            int m; // M = Quantidade de maçãs.
            float res;
            Console.WriteLine("Coloque a quantidade de maçãs que quer comprar: ");
            Console.WriteLine("Maçãs: Se comprar pelo menos uma dúzia: R$ 1,00 cada.");
            Console.WriteLine("Se comprar menos que uma dúzia: R$ 1,30 cada");
            m = int.Parse(Console.ReadLine());
            if (m >= 12)
            {
                Console.WriteLine("Total da compra: R${0}", m);
            }
            else
            {
                res = m * 1.3f;
                Console.WriteLine("Total da compra: R${0}", res);
            }
            Console.ReadKey();
        }
    }
}
