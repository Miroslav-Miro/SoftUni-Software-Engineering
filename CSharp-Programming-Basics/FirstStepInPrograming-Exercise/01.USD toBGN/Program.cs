using System;

namespace _01.USD_toBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usdVar = 1.79549;
            double usd = double.Parse(Console.ReadLine());

            double total = usdVar * usd;

            Console.WriteLine($"{total:f2}");







        }
    }
}
