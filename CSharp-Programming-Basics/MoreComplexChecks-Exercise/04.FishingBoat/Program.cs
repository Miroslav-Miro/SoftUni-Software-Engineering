using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int howMuch = int.Parse(Console.ReadLine());
            double total = 0;
            double need = 0;
            double more = 0;

            if (season == "Spring")
            {
                if (howMuch <= 6)
                {
                    total = 3000 * 0.90;
                }
                else if (howMuch >= 7 && howMuch <= 11)
                {
                    total = 3000 * 0.85;
                }
                else
                {
                    total = 3000 * 0.75;
                }
                if (howMuch % 2 == 0)
                {
                    total = total * 0.95;
                }

            }
            if (season == "Summer")
            {
                if (howMuch <= 6)
                {
                    total = 4200 * 0.90;
                }
                else if (howMuch >= 7 && howMuch <= 11)
                {
                    total = 4200 * 0.85;
                }
                else
                {
                    total = 4200 * 0.75;
                }
                if (howMuch % 2 == 0)
                {
                    total = total * 0.95;
                }

            }
            if (season == "Autumn")
            {
                if (howMuch <= 6)
                {
                    total = 4200 * 0.90;
                }
                else if (howMuch >= 7 && howMuch <= 11)
                {
                    total = 4200 * 0.85;
                }
                else
                {
                    total = 4200 * 0.75;
                }


            }
            if (season == "Winter")
            {
                if (howMuch <= 6)
                {
                    total = 2600 * 0.90;
                }
                else if (howMuch >= 7 && howMuch <= 11)
                {
                    total = 2600 * 0.85;
                }
                else
                {
                    total = 2600 * 0.75;
                }
                if (howMuch % 2 == 0)
                {
                    total = total * 0.95;
                }
            }
            need = total - budget;
            more = budget - total;
            if (budget>=total)
            {
                Console.WriteLine($"Yes! You have {more:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {need:f2} leva.");
            }
        }
    }
}
