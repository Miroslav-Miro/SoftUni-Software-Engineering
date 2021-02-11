using System;

namespace _04.InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = 2.54;

            double cm = double.Parse(Console.ReadLine());
            double result = cm * inch;

            Console.WriteLine(result);

        }
    }
}
