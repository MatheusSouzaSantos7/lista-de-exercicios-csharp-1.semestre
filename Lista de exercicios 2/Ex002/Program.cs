using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Ler um número e dizer se ele é impar ou par.
            int A, S;
            Console.Write("Escreva um número: ");
            A = int.Parse(Console.ReadLine());
            S = A % 2; // Assim, se for par, o resultado será 0. Se for Impar, o resultado será 1.
            if (S == 0)
                Console.Write("{0} é um número par", A);
            else
                Console.Write("{0} é um número impar", A);
            Console.ReadKey();
        }
    }
}
