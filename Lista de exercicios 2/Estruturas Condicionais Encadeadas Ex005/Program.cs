using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler dois valores e imprimir uma das três mensagens a seguir:
               ‘Números iguais’, caso os números sejam iguais
               ‘Primeiro é maior’, caso o primeiro seja maior que o segundo;
               ‘Segundo maior’, caso o segundo seja maior que o primeiro */
            int n1, n2;
            Console.Write("Escreva um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva outro número: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.Write("{0} é maior que {1}", n1, n2);
            }
            else if (n1 == n2)
            {
                Console.Write("Você digitou dois número iguais");
            }
            else
            {
                Console.Write("{0} é maior que {1}", n2, n1);
            }
            Console.ReadKey();
        }
    }
}
