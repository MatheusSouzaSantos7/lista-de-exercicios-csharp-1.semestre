using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: . Calcular e exibir a soma dos “N” primeiros valores da seqüência abaixo. O valor “N”
               será digitado, deverá ser positivo, mas menor que cem. Caso o valor não satisfaça a
               restrição, enviar mensagem de erro e solicitar o valor novamente. A seqüência: 2, 5,
               10, 17, 26, .... */

            int n, ct, res, b; // Obs.: Vai sempre somar com um número ímpar para conseguir o próximo valor

            ct = 1; // Contador
            res = 2; // Variável em que se inicia, primeiro resultado obtido
            b = 3; // Segundo número inteiro positivo do conjunto dos números naturais

            Console.Write("Digite o valor: ");
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n >= 100) // Após pedir o valor, é testado se o valor escrito está entre 1 e 100.
                {
                    Console.WriteLine("Valor não aceito. O valor precisa estar entre 1 e 99");
                    Console.Write("Digite o valor: ");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(res); // Escreve o primeiro resultado para utilizar como base para os demais resultados.
            while (ct <= n-1)  // O valor digitado está subtraido por um porque o primeiro resultado já foi escrito.
            {
                if (b % 2 == 1) // 0 = Número par. 1 = Número impar. Se o valor for impar, então vai somar, se não, vai incrementar.
                {
                    res += b;
                    Console.WriteLine(res);
                    ct++;
                    b++;
                }
                else
                {
                    b++;
                }
            }
            Console.ReadKey();
        }
    }
}
