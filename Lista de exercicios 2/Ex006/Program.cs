using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Ler um número e escrever "Maior que 100", se o número digitado for maior que 100, e escreva "Menor que 100" se o número for menor que 100.
            int n;
            Console.Write("Escreva um número: ");
            n = int.Parse(Console.ReadLine());
            if (n >= 100)
            {
                if (n == 100)
                {
                    Console.WriteLine("É o número 100"); // Como que o exercício não especifica o 100, optei por colocar uma condição em caso o número seja 100.
                }
                else
                    Console.Write("O número é maior que 100");
            }
            else
                Console.Write("O número é menor que 100");
            Console.ReadKey();
        }
    }
}
