using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: 1. Criar uma rotina de entrada que aceite somente um valor positivo.

            int n1;
            Console.Write("Escreva um número positivo: ");
            while (true)
            {
                n1 = int.Parse(Console.ReadLine());
                if (n1 < 0)
                {
                    Console.WriteLine("Número menor que zero! Redigite: ");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Correto! Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
