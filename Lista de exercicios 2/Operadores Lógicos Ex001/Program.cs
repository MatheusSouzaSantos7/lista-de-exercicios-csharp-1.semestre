using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Lógicos_Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Objetivo: Faça um Algoritmo que leia as coordenadas de um ponto no plano (x,y) e escreva o quadrante ao qual pertence o ponto no plano. 
                No primeiro quadrante x e y são positivos. No segundo quadrante y é positivo. 
                No terceiro quadrante nem x nem y é positivo. No quarto quadrante x é positivo */
            double x, y;
            Console.Write("Escreva a coordenada x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Escreva a coordenada y: ");
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.Write("O ponto no plano está no primeiro quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.Write("O ponto no plano está no segundo quadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.Write("O ponto no plano está no terceiro quadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.Write("O ponto no plano está no quarto quadrante");
            }
            Console.ReadKey();
        }
    }
}
