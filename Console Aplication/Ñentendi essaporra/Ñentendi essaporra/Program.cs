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
             Elabore um programa que determine o valor da sequência S, em que:
             S = 1/1 + 3/2 + 5/3 + 7/4 + .... + 99/50
             */
             int numerador = 1;
             float h=0,denominado=0;

              for (int denominador=1; denominador<=50; denominador++) {
                h = h + (numerador / denominado);
                numerador = numerador + 2;
              }
                Console.WriteLine("H = 1/1 + 3/2 + 5/3 + 7/4 + ... + 99/50" + h);
                 Console.ReadLine();
                }
                
               
            }
 }

