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
             Efetuar a leitura de três valores (variáveis A, B e C) de qualquer tipo e apresentar os valores
             em ordem crescente.
            */
            double a, b, c;
            Console.WriteLine("Informe 3 valores");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine("Ordem crescente:\n" + c + "\n" + b +"\n" + a);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("Ordem crescente:\n" + c + "\n" + a + "\n" + b);
            }
            else if (c > a && a > b)
            {
                Console.WriteLine("Ordem crescente:\n" + b + "\n" + a + "\n" + c);
            }
            else if(a>c && c>b)
            {
                Console.WriteLine("Ordem crescente:\n" + b + "\n" + c + "\n" + a);
            }
            else if (b > c && c > a) {
                Console.WriteLine("Ordem crescente:\n" + a + "\n" + c + "\n" + b);
            }
            /*   
            * else if (c > b && b > a)
           {
               Console.WriteLine("Ordem crescente:\n" + a + "\n" + b + "\n" + c);
           }
            */
            else
            {
                Console.WriteLine("Ordem crescente:\n" + a +"\n" + b +"\n" + c);
            }
            Console.ReadLine();
        }
    }
}
