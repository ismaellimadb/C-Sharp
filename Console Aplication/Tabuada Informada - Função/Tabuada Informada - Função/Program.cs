using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Tabuada(int num) 
        {
            for (int i = 1; i <= 10; i++ )
            {
                Console.WriteLine(num + "X" + i + "=" + num*i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inteiro");
            int a = Convert.ToInt32(Console.ReadLine());
            Tabuada(a);
            Console.Read();
        }
    }
}
