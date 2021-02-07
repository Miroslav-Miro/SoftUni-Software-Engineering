using System;

namespace _04.Vacationbookslist
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numberPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int numberDays = int.Parse(Console.ReadLine());

            //calculations
            double totalTimeForReading = numberPages / pagesPerHour;
            double hourPerDay = totalTimeForReading / numberDays;

            //output
            Console.WriteLine(hourPerDay);
        }
    }
}
