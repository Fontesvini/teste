using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string nome = "";
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine()?? "";
            Console.WriteLine($"seu nome é: {nome}");

            float numeroQualquer = 5f/2;
            Console.WriteLine(numeroQualquer);

            bool teste = 2<=200;
            Console.WriteLine(teste);
            

            int a = 2;
            int b = 10;
            int c = 20;

            if (a > b && a < c)
            {
                Console.WriteLine("é verdade!");
            }
            else if (a > c || b > c)
            {
                Console.WriteLine("tu conseguiu errar isso");
            }
            else
            {
                Console.WriteLine("é mentira!");
            }

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if (idade >= 13 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente!");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto!");   
            }
            else 
            {
                Console.WriteLine("Você é um idoso!");
            }
            */

            int soma1 = Valor(20, 30, 40);
            int soma2 = Valor(10,30,20);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            
            Console.ReadLine();
        }   

        static void GerarPreco(int Preco)
        {
            int precoAbs = Math.Abs(Preco);
            int valorFinal = precoAbs + (2* precoAbs);
            Console.WriteLine($"O valor final é: {valorFinal}");
        }

        static int Valor(int A, int B, int C)
        {
            int ValorTotal = A + B + C;
            return ValorTotal;
        }

    }
}
