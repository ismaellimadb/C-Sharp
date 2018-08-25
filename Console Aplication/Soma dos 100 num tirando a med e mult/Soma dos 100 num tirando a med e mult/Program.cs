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
            //Feito tirando a média do 1º termo com último e multiplicando pela quantidade dos termos.
            //Double é necessario senão o programa arredondara a média dos dois termos, dando resultado errado.
            double result, a=1,b=100;
            result = (a + b)/2*100;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
