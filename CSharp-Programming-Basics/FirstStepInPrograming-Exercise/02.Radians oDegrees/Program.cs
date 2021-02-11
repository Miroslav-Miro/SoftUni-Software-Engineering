using System;

namespace _02.Radians_oDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 180;

            //input
            double radians = double.Parse(Console.ReadLine());

            //calculate
            double degrees = radians * p / Math.PI;

            Console.WriteLine(Math.Round(degrees));

        }
    }
}
