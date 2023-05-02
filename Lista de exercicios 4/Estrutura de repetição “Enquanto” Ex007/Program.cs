using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Exibir a tabuada dos valores de um a vinte, no intervalo de um a dez. Entre as
               tabuadas, solicitar que o usuário pressione uma tecla. */
            int c, n, res;
            c = 1;
            n = 1;
            while (n <= 20)
            {
                while (c <= 10)
                {
                    res = n * c;
                    Console.WriteLine("{0} x {1} = {2}", n, c, res);
                    c++;
                }
                Console.WriteLine();
                if (n <=19)
                {
                    Console.WriteLine("Presione ENTER para ir para a próxima tabuada");
                    Console.ReadKey();
                }
                Console.WriteLine();
                n++;
                c = 1;

            }
            Console.WriteLine("A tabuada acabou, aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
