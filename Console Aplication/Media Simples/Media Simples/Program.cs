using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double media;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a media");
            media = Convert.ToDouble(Console.ReadLine());

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado!\nCom media de: " + media);
            }
            else
            {
                Console.WriteLine("REPROVADO!!!\nCom media de: " + media);
            }

            Console.ReadLine();
        }
    }
}
