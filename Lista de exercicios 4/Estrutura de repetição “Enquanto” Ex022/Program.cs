using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__Ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Calcular o fatorial de um número. O valor não pode ser negativo. Perguntar se quer fazer um novo cálculo, S ou N */
            int n, a;
            string b;
            while (true)
            {
                Console.Write("Digite um número: ");
                while (true)
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.Write("NÚMERO NEGATIVO! Digite outro número: ");
                    }
                    else
                    {
                        break;
                    }
                }
                a = n-1;
                Console.Write("O fatorial de {0} é ", n);
                if (a == -1)
                {
                    n =  1;
                }
                while (a >= 1)
                {
                    n = n * a;
                    a--;
                }
                Console.WriteLine(n);
                while (true)
                {
                    Console.WriteLine("Deseja calcular um novo número? S ou N:");
                    b = Console.ReadLine();
                    if (b == "N")
                    {
                        break;
                    }
                    else if (b == "S")
                    {
                        Console.WriteLine("Reiniciando...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Comando não aceito! escolha S ou N");
                    }
                }
                if (b == "N")
                {
                    break;
                }
            }
            Console.Write("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
