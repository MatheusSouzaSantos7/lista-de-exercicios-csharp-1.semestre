using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Entrar com dois valores via teclado, onde o segundo deverá ser maior que o
               primeiro. Caso contrário solicitar novamente apenas o segundo valor. */

            double v1, v2;
            Console.Write("Escreva o valor 1: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Escreva o valor 2: ");
            while (true)
            {
                v2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                if (v1 >= v2)
                {
                    Console.Write("O valor 2 deve ser maior que o valor 1. Redigite: ");
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine("Isso! {0} é maior que {1}. Aperte qualquer tecla para sair", v2, v1);
            Console.ReadKey();
        }
    }
}
