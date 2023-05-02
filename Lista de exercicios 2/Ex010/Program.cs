using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que
               diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a
               pessoa nasceu). */

            int ano, ano_nascimento;
            Console.Write("Coloque a sua data de nascimento: ");
            ano_nascimento = int.Parse(Console.ReadLine());
            if (ano_nascimento > 2007)    // Só pode votar a partir dos 16 anos de idade.
            {
                Console.WriteLine("Tem menos de 16 anos, não pode votar");
            }
            else
            {
                Console.Write("É maior de 16 anos, pode votar");
            }
            Console.ReadKey();
        }
    }
}
