using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler 3 valores (A, B e C) representando as medidas dos lados de um triângulo e
               escrever se formam ou não um triângulo. OBS: para formar um triângulo, o valor de
               cada lado deve ser menor que a soma dos outros 2 lados */
            int A, B, C;
            Console.Write("Escreva o lado 1 do triângulo: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Escreva o lado 2 do triângulo: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Escreva o lado 3 do triângulo: ");
            C = int.Parse(Console.ReadLine());
            if (A < B + C && B < C + A && C < B + A)
            {
                Console.Write("Forma um triângulo");
            }
            else
            {
                Console.Write("Não forma um triângulo");
            }
            Console.ReadKey();
        }
    }
}
