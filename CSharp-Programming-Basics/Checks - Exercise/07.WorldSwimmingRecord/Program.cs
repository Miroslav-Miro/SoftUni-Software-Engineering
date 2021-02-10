using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double sec = double.Parse(Console.ReadLine());
            double dis = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double howMany = dis * timeInSec;
            double slowing = dis / 15;
            slowing = Math.Floor(slowing);
            double slowing1 = slowing * 12.5;
            double totalSec = howMany + slowing1;
            if (sec <= totalSec)
            {
                Console.WriteLine($"No, he failed! He was {totalSec - sec:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSec:f2} seconds.");
            }
        }
    }
}
