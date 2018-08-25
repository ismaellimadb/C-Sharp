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
             Desenvolver um programa que apresente o valor total da soma de todos os números
            inteiros divisíveis por 3 e por 4 ao mesmo tempo e que sejam menores ou iguais a 400,
            iniciando a contagem em 1. 
             */
            int num = 1,ac=0;
            while (num <= 400) {
                if ((num % 3 == 0) && (num % 4 ==0)) {
                    ac += num;
                }
                num++;
            }
            Console.WriteLine(ac);
            Console.ReadLine();
        }
    }
}
