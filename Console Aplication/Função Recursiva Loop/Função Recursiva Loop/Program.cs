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
            loop(1);
            Console.Read();
        }
        public static void loop(int a)
        {
             Console.WriteLine(a);
                if (a < 3)
                {
                    loop(a+1);
                }
        }
    }
}
