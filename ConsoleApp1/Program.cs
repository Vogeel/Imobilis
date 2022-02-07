using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HotPao, o Melhor da Região");

            Console.Write("Número de pãos vendidos: ");

            double pao = double.Parse(Console.ReadLine());

            Console.Write("Número de broas vendidas: ");

            double broa = double.Parse(Console.ReadLine());

            double totalpao = pao * 0.12;

            double totalbroa = broa * 1.5;

            double total = totalpao + totalbroa;

            Console.WriteLine($"valor adquirido hoje: {total} reais");

            Console.WriteLine("Pressione 'Enter' para saber o quando guarda na poupança");

            Console.ReadLine();

            double poupanca = total * 0.10;

            Console.WriteLine($"Deve-se guardar: {poupanca} reais");

            Console.ReadLine();
        }
    }
}
