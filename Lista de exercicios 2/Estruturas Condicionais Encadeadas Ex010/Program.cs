using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Faça um Algoritmo que leia o código de uma mercadoria e que escreva o nome do
               produto conforme tabela abaixo:
                1 – Sabão
                2 – Vassoura
                3 – Detergente */
            int codigo;
            Console.Write("Escreva o valor do código: ");
            codigo = int.Parse(Console.ReadLine());
            switch (codigo)
            {
                case 1:
                    Console.Write("Sabão");
                    break;
                case 2:
                    Console.Write("Vassoura");
                    break;
                case 3:
                    Console.Write("Detergente");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
