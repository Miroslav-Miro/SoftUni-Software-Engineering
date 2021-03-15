using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dollars = 1.31M;
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal ToDollars = pounds * dollars;

            Console.WriteLine($"{ToDollars:f3}");
        }
    }
}
