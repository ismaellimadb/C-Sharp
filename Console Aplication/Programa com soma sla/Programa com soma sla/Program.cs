using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que receba um inteiro positivo entre 1 e 5, calcule e mostre
             a soma dos 10 primeiros termos da série abaixo.
             */
            int i, x, fatorial=1; double y=0;
            Console.WriteLine("Informe um numero inteiro positivo");
            x = Convert.ToInt32(Console.ReadLine());
            if ((x < 1) || (x > 5))
            {
                Console.WriteLine("Valor fora do intervalo solicitado");
            }
            else {
                for (i = 1; i <= 10; i++) {
                    fatorial = i * fatorial;
                    y = y + ((x ^ i) / fatorial);
                }
                Console.WriteLine("Resultado = " + y);
            }
            Console.ReadLine();
        }
    }
}
