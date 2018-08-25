using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double nota1, nota2, nota3, media;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota");
            nota3 = Convert.ToDouble(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7)
            {
                Console.WriteLine("Aprovado o Aluno\nCom media: " + media);//media.ToString(#.##) Não Funciona :(
            }
            else {
                Console.WriteLine("Reprovado!!!\nO Aluno com media de: " + media);
            }
            Console.ReadLine();
        }
    }
}
