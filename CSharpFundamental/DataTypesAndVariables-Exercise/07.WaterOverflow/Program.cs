using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litters = 0;
            int littersTotal = 255;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                litters = int.Parse(Console.ReadLine());
                

                if (litters <= littersTotal)
                {
                    littersTotal -= litters;
                    total += litters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(total);
        }
    }
}
