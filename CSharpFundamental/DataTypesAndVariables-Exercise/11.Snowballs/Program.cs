using System;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            double days = 0;
            double yieldForDay = 0;
            double total = 0;




            while (yield >= 100)
            {
                days++;

                yieldForDay = yield - 26;
                total += yieldForDay;
                yield -= 10;
                yieldForDay = 0;
            }

            if (total < 26)
            {
                Console.WriteLine(days);
                Console.WriteLine(total);
            }
            else 
            {
                total -= 26;
                Console.WriteLine(days);
                Console.WriteLine(total);
            }
            
        }
    }
}
