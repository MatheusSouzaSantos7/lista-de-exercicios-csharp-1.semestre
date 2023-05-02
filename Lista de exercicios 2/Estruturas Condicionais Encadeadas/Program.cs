using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Faça um Algoritmo que leia o salário bruto de uma pessoa e calcule o desconto do INSS levando em consideração o seguinte:
               • Para salários até R$ 500,00 a alíquota de INSS será de 8%
               • Para salários acima de R$ 500,00 até R$ 1.000,00 a alíquota de INSS será de 10%
               • Para salários acima de R$ 1.000,00 a alíquota de INSS será de 12%.
               No final deverá ser apresentado:
                a. Salário bruto
                b. Taxa de INSS
                c. Valor de INSS
                d. Salário líquido */

            // 1. Definição das variáveis
            double salario_bruto, taxa_INSS, valor_INSS, salario_liquido;

            // 2. Entrada
            Console.Write("Escreva o seu salário bruto: R$");
            salario_bruto = double.Parse(Console.ReadLine());

            // 3. Processamento
            if (salario_bruto <= 500)
            {
                taxa_INSS = 8; // No caso, é 8%. Será transformado em porcentagem na próxima linha.
                valor_INSS = salario_bruto * (taxa_INSS / 100);
                salario_liquido = salario_bruto - valor_INSS;
            }
            else if (salario_bruto > 500 && salario_bruto <= 1000)
            {
                taxa_INSS = 10; // No caso, é 10%.
                valor_INSS = salario_bruto * (taxa_INSS / 100);
                salario_liquido = salario_bruto - valor_INSS;
            }
            else
            {
                taxa_INSS = 12; // No caso, é 12%.
                valor_INSS = salario_bruto * (taxa_INSS / 100);
                salario_liquido = salario_bruto - valor_INSS;
            }
            // 4. Saída
            Console.WriteLine("Salário bruto: {0}", salario_bruto.ToString("R$##,##0.00"));
            Console.WriteLine("Taxa de INSS: {0}%", taxa_INSS);
            Console.WriteLine("Valor do INSS: {0}", valor_INSS.ToString("R$##,##0.00"));
            Console.WriteLine("Salário líquido: {0}", salario_liquido.ToString("R$##,##0.00"));
            Console.ReadKey();
        }
    }
}
