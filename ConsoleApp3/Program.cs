using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius? Não Obrigado, quero em Fahrenhiet");

            Console.Write("Graus em celsius: ");

            double C = double.Parse(Console.ReadLine());

            double F = C * 1.8 + 32;

            Console.WriteLine($"°{C} Graus Celsius, é igual a °{F} Fihrenhiet ");

            Console.ReadLine();
        }
    }
}
