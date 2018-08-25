using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int a, b, c, media;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe Tres Valores");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            media = (a * a) + (b * b) + (c * c);
            Console.WriteLine("A soma do quadrado desses três números é: " + media);
            Console.ReadLine();
        }
    }
}
