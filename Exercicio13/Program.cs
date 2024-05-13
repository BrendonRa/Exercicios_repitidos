using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + num * i);
            }

            Console.ReadKey();
        }
    }
}
