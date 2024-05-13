using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Digite primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (n1 > n2)
            {
                for (int i = n2; i <= n1; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Números inválidos");
            }

            Console.ReadKey();
        }
    }
}
