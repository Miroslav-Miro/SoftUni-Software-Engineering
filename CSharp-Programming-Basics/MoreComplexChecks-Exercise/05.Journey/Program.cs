using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seoson = Console.ReadLine();
            double total = 0;
            

            if (budget<=100)
            {
                if (seoson == "summer")
                {
                    total = budget * 0.30;
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($" Camp - {total:f2}");

                }
                else if (seoson == "winter")
                {
                    total = budget * 0.70;
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($" Hotel - { total:f2}");
                }
               
            }
            else if (budget <=1000)
            {
                if (seoson == "summer")
                {
                    total = budget * 0.40;
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($" Camp - {total:f2}");

                }
                else if (seoson == "winter")
                {
                    total = budget * 0.80;
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($" Hotel - { total:f2}");
                }
            }
            else
            {
                total = budget * 0.90;
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($" Hotel - { total:f2}");
            }
        }
    }
}
