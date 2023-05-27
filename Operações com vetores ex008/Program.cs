using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_com_vetores_ex008
{
    internal class Program
    {
        public static (string[], string[], int[]) Entrada()
        {
            string[] p = new string[10];
            string[] sexo = new string[10];
            int[] idade = new int[10];

            int ct;
            for (ct = 0; ct < 10; ct++) // nome
            {
                Console.Write("Enter the name of the {0}° person: ", ct + 1);
                p[ct] = Console.ReadLine();
            }
            for (ct = 0; ct < 10; ct++) // sexo
            {
                Console.Write("Enter the gender of the {0}° person (F/M): ", ct + 1);
                sexo[ct] = Console.ReadLine();
            }
            for (ct = 0; ct < 10; ct++) // Idade
            {
                Console.Write("Enter the age of the {0}° person: ", ct + 1);
                idade[ct] = int.Parse(Console.ReadLine());
            }

            return (p, sexo, idade);
        }
        public static (string[], string[], int[]) Processamento()
        {

        }

        public static void Main(string[] args)
        {
            /* Objetivo: Armazenar o nome, sexo e idade de 10 pessoas. Consistir as entradas no sentido de
                aceitar apenas “F” ou “M” para o sexo e valores positivos para a idade. Após a
                digitação, exibir os dados (nome, sexo e idade) de todas as pessoas com idade superior
                a dezoito anos. Ao final da lista, exibir a quantidade de pessoas listadas.*/

            // Declaração de variáveis
            string[] p;
            string[] sexo;
            int[] idade;

            Console.WriteLine("Programa que cria lista de pessoas com mais de 18 anos");
            (p, sexo, idade) = Entrada();

            Console.WriteLine("Pessoas com mais de 18 anos:");
            int ct = 0;
            for (int i = 0; i < 10; i++)
            {
                if (idade[i] > 18)
                {
                    Console.WriteLine("Nome: {0}, Gênero: {1}, Idade: {2}", p[i], sexo[i], idade[i]);
                    ct++;
                }
            }
            Console.WriteLine("Número de pessoas listadas: {0}", ct);

            Console.ReadKey();
        }
    }

}
