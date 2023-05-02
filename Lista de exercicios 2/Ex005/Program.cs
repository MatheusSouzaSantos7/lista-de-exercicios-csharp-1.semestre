using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetivo:Ler 4 notas escolares. Apresentar a média. A nota mínima de aprovação é 6, apresente se o aluno foi APROVADO ou REPROVADO

            float nt1, nt2, nt3, nt4, m;
            Console.Write("Escreva a primeira nota: ");
            nt1 = float.Parse(Console.ReadLine());
            Console.Write("Escreva a segunda nota: ");
            nt2 = float.Parse(Console.ReadLine());
            Console.Write("Escreva a terceira nota: ");
            nt3 = float.Parse(Console.ReadLine());
            Console.Write("Escreva a quarta nota: ");
            nt4 = float.Parse(Console.ReadLine());
            m = (nt1 + nt2 + nt3 + nt4) / 4.0f;
            if (m >= 6)
            {
                Console.Write("Média final: {0}, o aluno foi aprovado", m);
            }
            else
                Console.Write("Média final: {0}, aluno foi reprovado", m);
            Console.ReadKey();
        }
    }
}
