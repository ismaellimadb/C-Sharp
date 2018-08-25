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
            //Apresentar o total da soma dos quadrados dos números inteiros de 2 a 5.
            int num = 2,quad,ac=0;
            while (num <= 5) {
                quad = num * num;
                ac += quad;
                num++;
            }
            Console.WriteLine(ac);
            Console.ReadLine();
        }
    }
}
