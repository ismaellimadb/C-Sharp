using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elaborar um programa que efetue e apresente o somatório dos N primeiros números inteiros
            (1+2+3,....,+N), no qual o usuário determina o valor de N.*/
            int n, num,ac=0;
            Console.WriteLine("Informe um valor inteiro");
            n = Convert.ToInt32(Console.ReadLine());
            for (num = 0; num <= n; num++)
            {
                ac += num;
            }
            Console.WriteLine("A soma de todos os valores anteriores inclusive o informado é:\n" + ac);
            Console.ReadLine();
        }
    }
}
