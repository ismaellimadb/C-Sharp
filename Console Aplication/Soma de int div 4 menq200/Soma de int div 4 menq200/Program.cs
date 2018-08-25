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
            // Apresentar o total da soma de todos os números inteiros divisíveis por 4 que sejam menores que 200, iniciando a contagem em 1.

            int ac = 0, num = 1;
            while (num < 200)
            {
                if (num % 4 == 0) {
                    ac += num;
                }
                num++;
            }
            Console.WriteLine(ac);
            Console.ReadLine();
        }
    }
}
