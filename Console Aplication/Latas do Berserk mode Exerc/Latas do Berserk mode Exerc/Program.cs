using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double area, litro, qtde, custo, raio, altura, preco;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Altura");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o raio");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o preco da lata de tinta");
            preco = Convert.ToDouble(Console.ReadLine());
            area = (3.14 * raio * raio) + (2 * 3.14 * raio * altura);
            litro = area / 3;
            qtde = litro / 5;
            custo = qtde * preco;
            Console.WriteLine("A quantidade de latas de tintas nescessarias e: " + qtde);
            Console.WriteLine("O custo para pintar e: " + custo);
            Console.ReadLine();
        }
    }
}
