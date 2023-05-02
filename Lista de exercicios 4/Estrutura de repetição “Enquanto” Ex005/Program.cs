using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_repetição__Enquanto__ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Entrar via teclado com um valor qualquer. Travar a digitação, no sentido de aceitar
               somente valores positivos. Após a digitação, exibir a tabuada do valor solicitado, no
               intervalo de um a dez */
            int n, res, c;
            Console.WriteLine("Criador de tabuadas");
            Console.Write("Digite um valor positivo: ");
            c = 1;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n < 0)
                {
                    Console.Write("Valor negativo não é aceito. Digite outro número: ");
                }
                else
                {
                    break;
                }
            }
            while (c <= 10)
            {
                res = n * c;
                Console.WriteLine("{0} x {1} = {2}", n, c, res);
                c++;
            }
            Console.ReadKey();
        }
    }
}
