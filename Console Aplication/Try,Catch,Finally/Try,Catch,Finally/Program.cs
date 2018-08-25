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
            try
            {
                string[] novo = new string[3];
                novo[0] = "Julius";
                novo[1] = "Chris";
                novo[2] = "Greg";
                string d = novo[4];
                Console.WriteLine(d);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("Your code is Done for");
            }
            Console.WriteLine("statements after finally executed");﻿
        }
    }
}
