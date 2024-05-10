using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Qual vai ser o valor do primeiro número ? ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Qual vai ser o valor do segundo número ? ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.WriteLine(i);
                }
            } else if (num1 > num2) 
            {
                for (int i = num2; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            } else
            {
                Console.WriteLine("Números inválidos");
            }

            Console.ReadKey();
        }
    }
}
