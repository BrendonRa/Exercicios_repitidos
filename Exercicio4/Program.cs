using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pontos;

            Console.Write("Quantos pontos tirou na prova ? ");
            pontos = int.Parse(Console.ReadLine());

            if (pontos >= 0 && pontos <= 30)
            {
                Console.Write("REGULAR");
            } else if (pontos >= 31 && pontos <= 60)
            {
                Console.Write("BOM");
            } else if (pontos >= 61 && pontos <= 90)
            {
                Console.Write("MUITO BOM");
            } else if (pontos >= 91 && pontos <= 100)
            {
                Console.Write("ÓTIMO");
            } else
            {
                Console.Write("PONTUAÇÃO INVÁLIDA");
            }

            Console.ReadKey();
        }
    }
}
