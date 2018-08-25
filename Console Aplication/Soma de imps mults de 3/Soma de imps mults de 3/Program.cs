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
            /*
              Elabore um programa que efetue a soma de todos os números ímpares que são múltiplos
              de 3 e que se encontram no conjunto dos números de 1 até N, no qual N é informado pelo
              usuário.
             */
            int n, num, ac=0;
            Console.WriteLine("Informa um numero");
            n = Convert.ToInt32(Console.ReadLine());
            for (num = 0; num <= n; num++) {
                if ((num % 2 != 0) && (num %3 == 0)) {
                    ac += num;
                }
            }
            Console.WriteLine("A soma dos impares até esse numero, que são multiplos de 3 é:\n" + ac);
            Console.ReadLine();
        }
    }
}
