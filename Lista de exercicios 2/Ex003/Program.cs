using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Faça um Algoritmo que leia dois números quaisquer, e escreva o resultado do cálculo do maior dividido pelo menor. */
            float n1, n2, d; // d é a variável que divide.
            Console.Write("Escreva um número: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Escreva outro número: ");
            n2 = float.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                d = n1 / n2;
                Console.Write("{0} dividido por {1} é igual a {2}", n1, n2, d);
            }
            else
            {
                d = n2 / n1;
                Console.Write("{0} dividido por {1} é igual a {2}", n2, n1, d);
            }
                
            Console.ReadKey();
        }
    }
}
