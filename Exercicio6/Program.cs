using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;

            Console.Write("Qual o número ? ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.Write("JANEIRO");
                    break;

                case 2:
                    Console.WriteLine("FERVEREIRO");
                    break;

                case 3:
                    Console.WriteLine("MARÇO");
                    break;

                case 4:
                    Console.WriteLine("ABRIL");
                    break;

                case 5:
                    Console.WriteLine("MAIO");
                    break;

                case 6:
                    Console.WriteLine("JUNHO");
                    break;

                case 7:
                    Console.WriteLine("JULHO");
                    break;

                case 8:
                    Console.WriteLine("AGOSTO");
                    break;

                case 9:
                    Console.WriteLine("SETEMBRO");
                    break;

                case 10:
                    Console.WriteLine("OUTUBRO");
                    break;

                case 11:
                    Console.WriteLine("NOVEMBRO");
                    break;

                case 12:
                    Console.WriteLine("DESEMBRO");
                    break;

                default:
                    Console.WriteLine("Não existe mês com esse número");
                    break;
            }

            /*
            if (mes == 1)
            {
                Console.Write("JANEIRO");
            } else if (mes == 2)
            {
                Console.WriteLine("FERVEREIRO");
            } else if (mes == 3)
            {
                Console.Write("MARÇO");
            } else if (mes == 4)
            {
                Console.Write("ABRIL");
            } else if (mes == 5)
            {
                Console.Write("MAIO");
            } else if (mes == 6)
            {
                Console.Write("JUNHO");
            } else if (mes == 7)
            {
                Console.Write("JULHO");
            } else if (mes == 8)
            {
                Console.Write("AGOSTO");
            } else if (mes == 9)
            {
                Console.Write("SETEMBRO");
            } else if (mes == 10)
            {
                Console.Write("OUTUBRO");
            } else if (mes == 11)
            {
                Console.Write("NOVEMBRO");
            } else if (mes == 12)
            {
                Console.Write("DESEMBRO");
            } else
            {
                Console.WriteLine("Não existe mês com esse número");   
            }
            */

            Console.ReadKey();
        }
    }
}
