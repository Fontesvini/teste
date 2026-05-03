using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine()?? "";
            Console.WriteLine($"seu nome é: {nome}");

            Console.ReadLine();
        }
    }
}
