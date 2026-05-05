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
            */

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

            Console.ReadLine();
        }
    }
}
