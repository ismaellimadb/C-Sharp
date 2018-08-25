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
             * Efetuar a leitura de uma temperatura medida em graus Celsius e apresentá-la convertida
               em graus Fahreinheit. A fórmula para conversão das temperaturas é F = (9 * C + 160) / 5,
               sendo F a temperatura em Fahreinheit e C a temperatura em Celsius. Se F for maior que 45
               e menor que 90, então escrever a seguinte mensagem: “Temperatura Normal.”
             */
            double celsius, farenheit;
            Console.WriteLine("Informe a temperatura em graus celsius");
            celsius = Convert.ToDouble(Console.ReadLine());
            farenheit = (9 * celsius + 160) / 5;
            Console.WriteLine("A temperatura em graus Farenheits é: " + farenheit);
            if (farenheit>45 && farenheit<90)
            {
                Console.WriteLine("Temperatura Normal");
            }
            Console.ReadLine();
        }
    }
}
