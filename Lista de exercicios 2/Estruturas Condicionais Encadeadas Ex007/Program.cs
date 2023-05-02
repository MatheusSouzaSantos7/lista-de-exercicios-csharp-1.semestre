using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais_Encadeadas_Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objetivo: Faça um algoritmo para ler um número que é um código de usuário. Caso este código
               seja diferente de um código armazenado internamente no algoritmo (igual a 1234) deve
               ser apresentada a mensagem ‘Usuário inválido!’. Caso o Código seja correto, deve ser
               lido outro valor que é a senha. Se esta senha estiver incorreta (a certa é 9999) deve
               ser mostrada a mensagem ‘senha incorreta’. Caso a senha esteja correta, deve ser
               mostrada a mensagem ‘Acesso permitido’. */
            int n1, codigo, senha;
            codigo = 1234;
            Console.Write("Digite o código de usuário: ");
            n1 = int.Parse(Console.ReadLine());
            while (n1 != 1234)
            {
                Console.WriteLine("Usuário inválido!");
                Console.Write("Digite o código de usuário: ");
                n1 = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());
            while (senha != 9999)
            {
                Console.WriteLine("Senha incorreta!");
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");
            Console.Write("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
