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
            //Apresentar o total da soma obtida dos cem primeiros números inteiros: (1+2+3+4+....+100).
            //Resultado Somando o Primeiro termo com o Segundo e dividindo pela metade do segundo termo.
            int a = 1, b = 100, soma;
            soma = (a + b) * (b / 2);
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
