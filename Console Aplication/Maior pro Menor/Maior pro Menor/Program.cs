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
                Efetuar a leitura de dois valores numéricos inteiros e apresentar o resultado da diferença do
                maior valor pelo menor valor.             
             */
            int a, b;
            Console.WriteLine("Informe dois valores inteiros");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("O valor " + a + " é maior que o valor" + b);
            }
            else {
                Console.WriteLine("O valor " + b + " é maior que o valor " + a);
            }
            Console.ReadLine();
        }
    }
}
