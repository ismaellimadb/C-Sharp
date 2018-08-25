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
             Apresentar o total da soma dos valores numéricos inteiros ímpares situados na faixa de 0 a
            20. Para verificar se um número é impar, efetuar o cálculo dentro do laço de repetição por
            meio do resto da divisão do valor do contador por 2. Se o resto obtido for diferente de zero,
            some os valores obtidos. Usar para essa verificação lógica a instrução If..Then..End If e o
            operador MOD para retornar o resto da divisão.
             */
            int imp = 0, ac = 0; double result;
            while (imp<=20) {
                if (imp % 2 != 0) {
                    ac = ac + imp;
                }
                imp++;
            }
            result = ac;
            Console.WriteLine("\n" + result);
            Console.ReadLine();
        }
    }
}
