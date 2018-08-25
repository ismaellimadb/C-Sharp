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
            Desenvolva um programa para calcular o valor de uma potência de uma base qualquer com
            um expoente qualquer. Por exemplo, se for mencionada no programa principal a sub-rotina
            POTENCIA(2,3), deve ser apresentado o valor 8. Não utilize formas internas (bibliotecas) de
            cálculo de potência. Utilize laço de repetição para a solução do problema.
             */
            int bas,exp,pot=1,c=0;
            Console.WriteLine("Informe o valor:");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elevado a:");
            exp = Convert.ToInt32(Console.ReadLine());
            while (c != exp) {
                pot = pot * bas;
                c++;
            }
            Console.WriteLine("O resultado do valor " + bas + " elevado a " + exp + " é: " + pot);
            Console.ReadLine();
        }
    }
}
