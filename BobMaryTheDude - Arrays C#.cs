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
            List<string> custumers = new List<string>();
            custumers.Add("Bob"); //0
            custumers.Add("Mary"); //1
            //Here
            custumers.Add("Chad"); //2

            custumers.Insert(2, "Heather");

            foreach (string custumer in custumers)
            {
                Console.WriteLine(custumer);
            }
            List<int> ages = new List <int>();
            ages.Add(35);
            ages.Add(28);
            ages.Add(40);

            ages.Insert(2, 38);
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.Read();
        }
    }
}
