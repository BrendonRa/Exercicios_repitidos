using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um valor numérico entre 0 e 5: ");
            num = int.Parse(Console.ReadLine());

            switch (num) 
            {
                case 0:
                    Console.Write("ZERO");
                    break;

                case 1:
                    Console.Write("UM");
                    break;

                case 2:
                    Console.WriteLine("DOIS");
                    break;

                case 3:
                    Console.WriteLine("TRÊS");
                    break;

                case 4:
                    Console.WriteLine("QUATRO");
                    break;

                case 5:
                    Console.WriteLine("CINCO");
                    break;
            }

            /*if (num == 0)
            {
                Console.Write("ZERO");
            } else if (num == 1)
            {
                Console.Write("UM");
            } else if (num == 2)
            {
                Console.Write("DOIS");
            } else if (num == 3)
            {
                Console.Write("TRES");
            } else if (num == 4)
            {
                Console.Write("QUATRO");
            } else if (num == 5)
            {
                Console.Write("CINCO");
            }*/

            Console.ReadKey();
        }
    }
}
