using System;

namespace Imobilis.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador de área");

            Console.WriteLine("Para descobrir a área do terreno:");

            Console.Write("Digite a Largura do terreno: ");

            float Largura = float.Parse(Console.ReadLine());

            Console.Write("Digite o Comprimento do terreno: ");

            float Comprimento = float.Parse(Console.ReadLine());

            float resultado = Largura * Comprimento;

            Console.WriteLine(resultado );

            Console.ReadLine();




        }
    }
}
