using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Exx003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler o nome de 2 times e o número de gols marcados na partida (para cada time).
               Escrever o nome do vencedor. Caso não haja vencedor deverá ser impressa a palavra EMPATE. */
            string time1, time2;
            int gol_time1, gol_time2;

            Console.WriteLine("Escreva o nome e a quantidade de gols de cada time");
            Console.Write("Nome do time 1: ");
            time1 = Console.ReadLine();
            Console.Write("Quantidade de gols do time 1: ");
            gol_time1 = int.Parse(Console.ReadLine());
            Console.Write("Nme do time 2: ");
            time2 = Console.ReadLine();
            Console.Write("Quantidade de gols do time 2: ");
            gol_time2 = int.Parse(Console.ReadLine());
            if (gol_time1 >= gol_time2)
            {
                if (gol_time1 == gol_time2)
                {
                    Console.Write("Empate");
                }
                else
                {
                    Console.Write("O time {0} ganhou", time1);
                }
            }
            else
            {
                Console.Write("O time {0} ganhou", time2);
            }
            Console.ReadKey();
        }
    }
}
