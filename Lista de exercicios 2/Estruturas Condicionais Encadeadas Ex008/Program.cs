using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um Algoritmo que leia o valor do salário hora, a quantidade de horas trabalhadas
               e a quantidade de filho menores de 14 anos de um funcionário. 
               Calcular o valor do salário bruto. Para calcular o valor do salário família levar em consideração o seguinte:
               • Se o salário bruto for até R$ 500,00 o salário família será de R$ 10,50 por cada filho
               • Se o salário bruto for acima de R$ 500,00 até R$ 1.000,00 o salário família será de R$ 6,50 por cada filho
               • Se o salário bruto for acima de R$ 1.000,00 o salário família será de R$ 1,50 por cada filho
               No final apresentar o valor do salário bruto e o valor do salário família a ser recebido */

            int filhos ; // sh = Salário hora, ht = Quantidade de horas trabalhadas
            double sh, ht, salario_familia, salario_bruto ;
            Console.WriteLine("Qual é o seu salário por hora?");
            sh = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas você trabalhou?");
            ht = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos filhos você tem?");
            filhos = int.Parse(Console.ReadLine());

            // Processamento
            salario_bruto = sh * ht;
            if (salario_bruto <= 500)
            {
                salario_familia = filhos * 10.50;
                Console.WriteLine("O salário família será de R$10,50 por filho");
            }
            else if (salario_bruto < 500 && salario_bruto <= 1000)
            {
                salario_familia = filhos * 6.50;
                Console.WriteLine("O salário família será de R$6,50 por filho");
            }
            else
            {
                salario_familia = filhos * 1.50;
                Console.WriteLine("O salário família será de R$1,50 por filho");
            }

            // Saída
            Console.WriteLine("O salário bruto é de {0}", salario_bruto.ToString("R$##,##0.00"));
            Console.WriteLine("O salário família é de {0}", salario_familia.ToString("R$##,##0.00")); // Optei por transformar o salário familia em String.
            Console.ReadKey();
        }
    }
}
