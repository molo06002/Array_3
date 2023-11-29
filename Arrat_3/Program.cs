// See https://aka.ms/new-console-template for more information
using System;
namespace array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            Console.WriteLine("Skriv in tal nmr 1: ");
            string tal1 = Console.ReadLine();
            int tal1_1 = Convert.ToInt32(tal1);
            tal[0] = tal1_1;
            Console.WriteLine("Skriv in tal nmr 2: ");
            string tal2 = Console.ReadLine();
            int tal2_2 = Convert.ToInt32(tal2);
            tal[1] = tal2_2;
            Console.WriteLine("Skriv in tal nmr 3: ");
            string tal3 = Console.ReadLine();
            int tal3_3 = Convert.ToInt32(tal3);
            tal[2] = tal3_3;
            Console.WriteLine(tal[0] + " " + tal[1] + " " + tal[2]);
            int summa = tal[0] + tal[1] + tal[2];
            Console.WriteLine("Summan: " + summa);
        }
    }
}