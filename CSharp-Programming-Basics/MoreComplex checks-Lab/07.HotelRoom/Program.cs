using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int howMany = int.Parse(Console.ReadLine());
            double apartment = 0;
            double studio = 0;

            if (month == "May" || month == "October")
            {
                if (howMany > 7 && howMany < 14)
                {
                    studio = 50 * 0.95;
                    apartment = 65;
                }
                else if (howMany > 14)
                {
                    studio = 50 * 0.70;
                    apartment = 65 * 0.90;
                }
                else
                {
                    studio = 50;
                    apartment = 65;
                }
            }
            if (month == "June" || month == "September")
            {
               
                 if (howMany > 14)
                {
                    studio = 75.20 * 0.80;
                    apartment = 68.70 * 0.90;
                }
                else
                {
                    studio = 75.20;
                    apartment = 68.70;
                }
            }
            if (month == "July" || month == "August")
            {

                if (howMany > 14)
                {
                    studio = 76 ;
                    apartment = 77 * 0.90;
                }
                else
                {
                    studio = 76;
                    apartment = 77;
                }
            }
            Console.WriteLine($"Apartment: {apartment*howMany:f2} lv.");
            Console.WriteLine($"Studio: {studio*howMany:f2} lv.");
        }
    }
}
