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
            int ano;
            Console.WriteLine("Informe seu ano");
            ano = Convert.ToInt32(Console.ReadLine());
            if ((ano % 4 == 0) && (ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine("O ano " + ano + " é bissexto");
            }
            else {
                Console.WriteLine("O ano " + ano + " não é bissexto");
            }
            Console.ReadLine();
        }
    }
}
