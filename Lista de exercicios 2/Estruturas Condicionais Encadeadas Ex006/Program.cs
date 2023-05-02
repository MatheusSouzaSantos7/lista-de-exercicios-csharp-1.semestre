using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Escreva um algoritmo que leia as idades de 2 homens e de 2 mulheres (considere que
               as idades dos homens serão sempre diferentes entre si, bem como as das mulheres).
               Calcule e escreva a soma das idades do homem mais velho com a mulher mais nova,
               e o produto das idades do homem mais novo com a mulher mais velha. */

            int ih1, ih2, im1, im2, res1, res2;
            Console.WriteLine("Programa que soma as idades do homem mais velho com a mulher mais nova, e o produto das idades do homem mais novo com a mulher mais velha.");
            Console.Write("Escreva a idade do homem 1: ");
            ih1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva a idade do homem 2: ");
            ih2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva a idade da mulher 1: ");
            im1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva a idade da mulher 2: ");
            im2 = int.Parse(Console.ReadLine());
            if (im1 > im2)
            {
                if (ih1 > ih2)
                {
                    res1 = ih1 + im2;
                    res2 = ih2 * im1;
                }
                else
                {
                    res1 = ih2 + im2;
                    res2 = ih1 * im1;
                }
            }
            else
            {
                if (ih1 > ih2)
                {
                    res1 = ih1 + im1;
                    res2 = ih2 + im2;
                }
                else
                {
                    res1 = ih2 + im1;
                    res2 = ih1 * im2;
                }
            }
            Console.Write("A soma é de {0} e o produto é de {1}", res1, res2);
        }
    }
}
