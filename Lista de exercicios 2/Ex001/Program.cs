using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler o maior número e escrever o maior entre eles.

            // 1. Definição das variáveis
            int A, B;
            Console.Write("Escreva um número: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Escreva outro número: ");
            B = int.Parse(Console.ReadLine());

            // 2. Processamento e saída
            if (A > B)
                Console.Write("O maior número é " + A);
            else
                Console.Write("O maior número é " + B);
            Console.ReadKey();
        }
    }
}
