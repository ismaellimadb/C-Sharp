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
            Escrever um programa para calcular o IMC (Índice de Massa Corpórea) conforme o
            português estruturado abaixo:
            programa IMC
            var PESO, ALTURA, IMC : real 
            nome : caracteres
            início
            escreva “Informe o Nome”
            leia NOME
            escreva “Informe o Peso”
            leia PESO
            escreva “Informe a Altura”
            leia ALTURA
            IMC ← (PESO) / (ALTURA * ALTURA)
            se IMC < 18,5 então
            escreva (nome , " o seu IMC é: " , IMC , " e sua classificação C é Magreza.")
            senão_se IMC >= 18,5 And IMC <= 24.9 então
            escreva (nome , " o seu IMC é: " , IMC , " e sua classificação é Saudável.")
            senão_se IMC >= 25 And IMC <= 29.9 então
            escreva (nome , " o seu IMC é: " , IMC , " e sua classificação é Sobrepeso.")
            senão_se IMC >= 30 And IMC <= 34.9 então
            escreva (nome , " o seu IMC é: " , IMC , " e sua classificação é Obesidade Grau
            I.")
            senão_se IMC >= 35 And IMC <= 39.9 então
            escreva (nome , " o seu IMC é: " , IMC , " e sua classificação é Obesidade Grau
            II (severa).")
            senão
            escreva (nome , " o seu IMC é: " , IMC , " e sua classificação é Obesidade Grau
            III (mórbida).")
            fim_se
            fim
            */
            double peso, altura, imc; string nome;
            Console.WriteLine("Informe seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Informe seu peso");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe sua altura");
            altura = Convert.ToDouble(Console.ReadLine());
            imc = peso / (altura * altura);
            if(imc<18.5){
                Console.WriteLine(nome + " O seu IMC é: " + imc + " E sua classificação é Magreza");
            }
            else if(imc>=18.5 && imc<=24.9){
                Console.WriteLine(nome + " O seu IMC é: " + imc + " E sua classificação é Saldavel");
            }
            else if (imc >= 25 && imc <= 29.9) {
                Console.WriteLine(nome + " O seu IMC é: " + imc + " E sua classificação é Sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9) {
                Console.WriteLine(nome + " O seu IMC é: " + imc + " E sua classificação é Obesidade grau I");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine(nome + " O seu IMC é: " + imc + " E sua classificação é Obesidade grau II(severa)");
            }
            else {
                Console.WriteLine(nome + " O seu IMC é: " + imc + " E sua classificação é Obesidade grau III(mórbida)");
            }
            Console.ReadLine();
        }
    }
}
