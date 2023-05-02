using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Entrar via teclado com o sexo de determinado usuário, aceitar somente “F” ou “M”
               como respostas válidas. */
            string sexo;

            Console.WriteLine("Qual é o sexo?");
            Console.WriteLine("Só será aceito as respostas M ou F");
            while (true)
            {
                sexo = Console.ReadLine();
                if (sexo != "M" && sexo != "F")
                {
                    Console.WriteLine("Informação não aceita. Digite M ou F");
                }
                else
                {
                    break;
                }
                
            }
            Console.Write("Sexo: {0}. Aperte qualquer tecla para sair", sexo);
            Console.ReadKey();
        }
    }
}
