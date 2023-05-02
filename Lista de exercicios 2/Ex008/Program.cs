using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Faça um algoritmo que leia a quantidade de vitóris e a quantidade de derrotas de um time de futebol.
             Escrever BOM se o número de vitórias for maior que o número de derrotas, caso contrário escrever RUIM */
            int v, d, res; // v = Vitória, d = Derrota, res = Resultado.
            Console.Write("Escreva o número de vitórias: ");
            v = int.Parse(Console.ReadLine());
            Console.Write("Escreva o número de derrotas: ");
            d = int.Parse(Console.ReadLine());
            res = v - d;
            if (res > 0)
            {
                Console.Write("BOM");
            }
            else if (res == 0)
            {
                Console.Write("Número de vitórias é igual ao número de derrotas");
            }
            else
                Console.Write("RUIM");
            Console.ReadKey();
        }
    }
}
