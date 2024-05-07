using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_repetidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            string nomeU;

            Console.Write("Digite o nome de usoário: ");
            nomeU = Console.ReadLine();
            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            if (senha == 1234 && nomeU == "joao")
            {
                Console.Write("SEJA BEM-VINDO!");
            } else
            {
                Console.Write("ACESSO NEGADO!");
            }

            Console.ReadKey();
        }
    }
}
