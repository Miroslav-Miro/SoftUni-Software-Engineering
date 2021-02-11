using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double month = 12;

            //input
            double deposite = double.Parse(Console.ReadLine());
            int termDeposite = int.Parse(Console.ReadLine());
            double yearIncreaseProcent = double.Parse(Console.ReadLine());

            //calculate
            double increace = deposite * yearIncreaseProcent/100;
            double calIncrease = increace / month;
            double price = deposite + termDeposite * calIncrease;

            Console.WriteLine(price);           

        }
    }
}
