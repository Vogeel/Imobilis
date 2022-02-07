using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Continue para saber quantos dias você está na Terra");

            Console.WriteLine("Qual seu nome?");

            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");

            string idade = Console.ReadLine();

            int idades = Convert.ToInt32(idade);

            int dias = idades * 365;

            Console.WriteLine($"Olá {nome}, você está há {dias} ocupando lugar na terra");

            Console.ReadLine();
        }
    }
}
