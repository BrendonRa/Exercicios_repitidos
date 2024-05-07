using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.Write("APROVADO!");
            } else
            {
                Console.Write("Qual a nota da recuperação ? ");
                float notaR = float.Parse(Console.ReadLine());

                if (notaR >= 5)
                {
                    Console.Write("APROVADO APÓS A RECUPERAÇÃO!");
                } else
                {
                    Console.Write("REPROVADO!");
                }
            }

            Console.ReadKey();
        }
    }
}
