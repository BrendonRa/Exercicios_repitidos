using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número entre 5 e 15: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 5 && numero <= 15)
            {
                Console.Write("PERTENCE AO CONJUNTO!");
            } else
            {
                Console.Write("FORA DO CONJUNTO!");
            }

            Console.ReadKey();
        }
    }
}
