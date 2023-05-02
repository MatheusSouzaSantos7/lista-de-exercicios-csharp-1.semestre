using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Ler um código. 1 - Sinal vermelho. 2 - Sinal verde. Baseado no código digitado diga para o pedestre que está esperando no sinal: "SIGA" ou "ESPERE".
            int n;
            Console.Write("Digite 1 ou 2: ");
            n = int.Parse(Console.ReadLine());
            if (n != 1 && n != 2)
            {
                Console.Write("Comando incorreto!");
            }
            else if (n == 1)
            {
                Console.WriteLine("Sinal vermelho. ESPERE");
            }
            else
                Console.Write("Sinal verde. SIGA");
            Console.ReadLine();
        }
    }
}
