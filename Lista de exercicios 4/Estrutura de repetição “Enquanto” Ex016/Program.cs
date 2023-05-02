using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Objetivo: . Exibir os trinta primeiros valores da série de Fibonacci. A série: 1, 1, 2, 3, 5, 8, … */

            int A, B, C, ct;
            A = 1;
            B = 1;
            Console.WriteLine(A);
            Console.WriteLine(B);
            ct = 3;
            while (ct <= 30)
            {
                C = A + B;
                A = B;
                B = C;
                Console.WriteLine(C);
                ct++;
            }
            Console.ReadKey();
        }
    }
}
