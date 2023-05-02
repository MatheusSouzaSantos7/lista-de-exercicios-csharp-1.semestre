using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: 4. Exibir a tabuada do número cinco no intervalo de um a dez.
            int c, res;
            Console.WriteLine("Tabuada do 5");
            c = 1;
            while (c <= 10)
            {
                res = 5 * c;
                Console.WriteLine("5 x {0} = {1}", c, res);
                c+= 1;
            }
            Console.ReadKey();
        }
    }
}
