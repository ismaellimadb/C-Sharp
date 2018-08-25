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
            int ac = 0, num=0;
            while (num <= 100) {
                ac += num;
                num++;
            }
            
            Console.WriteLine(ac);
            Console.ReadLine();
        }
    }
}
