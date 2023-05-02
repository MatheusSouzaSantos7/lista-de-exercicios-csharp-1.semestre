using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler 3 valores (considere que não serão informados valores iguais) e escrever a soma dos 2 maiores.
            int n1, n2, n3, res;
            Console.Write("Escreva um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva outro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva mais um número: ");
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    if (n3 > n2)
                    {
                        res = n1 + n3;
                    }
                    else
                    {
                        res = n1 + n2;
                    }
                }
                else
                {
                    res = n3 + n1;
                }
            }
            else if (n1 > n3)
            {
                res = n2 + n1;
            }
            else 
            { 
                res = n1 + n2; 
            }
            Console.ReadKey();
        }
    }
}
