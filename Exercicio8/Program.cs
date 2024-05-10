using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numF;

            Console.Write("Qual vai ser o número final ? ");
            numF = int.Parse(Console.ReadLine());

            if (numF != 0) {
                for (int i = 0; i <= numF; i++)
                {
                    Console.WriteLine(i);
                }
            } else {
                Console.Write("Valor inválido");
            }

            Console.ReadKey();
        }
    }
}
