using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Ler a receita e a despesa de uma empresa e apresentar se está com LUCRO ou PREJUÍZO

            float receita, despesa, res;
            Console.Write("Escreva a sua receita em R$: ");
            receita = float.Parse(Console.ReadLine());
            Console.Write("Escreva as suas despesas em R$: ");
            despesa = float.Parse(Console.ReadLine());
            res = receita - despesa;
            if (receita > despesa)
            {
                Console.Write("Você ganhou R${0},você está no lucro", res);
            }
            else
                Console.Write("Você perdeu - R${0}, você está no prejuízo ", Math.Abs(res)); // O comando Math.Abs() faz com que pegue o valor absoluto, sem se importar com o sinal
            Console.ReadKey();
        }
    }
}
