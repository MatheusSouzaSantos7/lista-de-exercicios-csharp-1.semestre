using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler um valor e escrever se é positivo, negativo ou zero.

            int n;
            Console.Write("Escreva um número: ");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.Write("O número é positivo");
            }
            else if (n == 0)
            {
                Console.Write("O número é zero");
            }
            else
            {
                Console.Write("O número é negativo");
            }
            Console.ReadKey();

        }
    }
}
