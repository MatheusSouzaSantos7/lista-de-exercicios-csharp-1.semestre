using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__Ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: . Em um jogo de adivinhação, o jogador deve descobrir um número entre 1 e 10
               usando até três tentativas. A cada tentativa o jogador é informado se o número foi
               descoberto, ou se ele é maior ou menor do que a tentativa. Se após três tentativas o
               jogador não descobrir o número, então ele perde o jogo. Faça um algoritmo que
               implemente esse jogo */

            int n, r, ct;
            Console.WriteLine("Descubra o valor. Você tem 3 tentativas.");
            Console.Write("Digite um valor entre 0 e 10: ");
            for (ct = 2; ct >= 0; ct--) // A partir do momento em que o usuário vai digitar um valor, ele já gastou uma tentativa. Por isso que começa com 2 tentativas.
            {
                n = 5; // O valor que deve ser acertado é 5.
                r = int.Parse(Console.ReadLine()); // r é o valor que o usuário informou.
                Console.WriteLine();
                if (r > 10)
                {
                    Console.Write("Valor maior que 10. Escreva outro valor: ");
                    ct++;
                }
                else if (r < 0)
                {
                    Console.Write("Valor menor que 0, peça outro valor: ");
                    ct++;
                }
                else if (r > n)
                {
                    Console.WriteLine("O número digitado é maior que o número certo");
                    Console.Write("Você tem {0} tentativas, digite outro valor: ", ct);
                }
                else if (r < n)
                {
                    Console.WriteLine("O número digitado é menor que o número certo");
                    Console.Write("Você tem {0} tentativas, digite outro valor: ", ct);
                }
                if (r == n)
                {
                    Console.WriteLine("Você acertou! Se errasse, você teria mais {0} tentativas. Aperte qualquer botão para sair", ct);
                    Console.ReadKey();
                    ct = -1;
                }
                if (ct == 0)
                {
                    Console.WriteLine("Você perdeu! Aperte qualquer tecla para sair");
                    Console.ReadKey();
                }
            }
        }
    }
}
