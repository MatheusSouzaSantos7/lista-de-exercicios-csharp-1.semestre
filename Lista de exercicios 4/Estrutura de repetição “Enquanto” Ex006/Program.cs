using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Entrar via teclado com um valor (X) qualquer. Travar a digitação, no sentido de
               aceitar somente valores positivos. 
               Solicitar o intervalo que o algoritmo que deverá calcular a tabuada do valor digitado, 
               sendo que o segundo valor (B), deverá ser maior que o primeiro (A), caso contrário, digitar novamente somente o segundo.
               Após a validação dos dados, exibir a tabuada do valor digitado, no intervalo
               decrescente, ou seja, a tabuada de X no intervalo de B para A. */

            int x, a, b, res;
            Console.Write("Escreva um número positivo: ");
            while (true)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.Write("Número negativo. Digite outro valor: ");
                }
                else
                {
                    break;
                }
                
            }
            Console.Write("Digite qual será o primeiro valor do intervalo a ser calculado: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite qual será o ultimo valor do intervalo a ser calculado: ");
            while(true)
            {
                b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    Console.Write("Último valor calculado é menor que o valor inicial. Digite outro valor: ");
                }
                else
                {
                    break;
                }
            }
            while (b >= a)
            {
                res = x * b;
                Console.WriteLine("{0} x {1} = {2}", x, b, res);
                b--;
            }
            Console.ReadKey();
            


        }
    }
}
