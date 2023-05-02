using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex_especial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Dentre os 1000 primeiros números inteiros positivos, exiba quais são perfeitos */
            int ct, n, a;
            n = 1;
            ct = 1;
            while (ct <= 1000)
            {
                n = 1;
                a = 0;
                while(n <ct)
                {
                    if (ct%n == 0)
                    {
                        a += n;
                        n++;
                    }
                    else
                    {
                        n++;
                    }
                }
                if ( a == ct)
                {
                    Console.WriteLine(ct);
                }
                ct++;
            }
            Console.ReadKey();
        }
    }
}
