using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double howMany =double.Parse(Console.ReadLine());

            
            if (day== "Monday" || day== "Tuesday" || day== "Wednesday"||day== "Thursday"||day=="Friday")
            {
                if (product == "banana")
                {
                    Console.WriteLine($"{howMany * 2.50:f2}"); 

                }
                else if (product == "apple")
                {
                    Console.WriteLine($"{howMany * 1.20:f2}");
                }
                else if (product == "orange")
                {
                    Console.WriteLine($"{howMany * 0.85:f2}");
                }
                else if (product == "grapefruit")
                {
                    Console.WriteLine($"{howMany * 1.45:f2}");
                }
                else if (product == "kiwi")
                {
                    Console.WriteLine($"{howMany * 2.70:f2}");
                }
                else if (product == "pineapple")
                {
                    Console.WriteLine($"{howMany * 5.50:f2}");
                }
                else if (product == "grapes")
                {
                    Console.WriteLine($"{howMany * 3.85:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if(day == "Saturday"||day == "Sunday")
            {
                if (product == "banana")
                {
                    Console.WriteLine($"{howMany * 2.70:f2}");

                }
                else if (product == "apple")
                {
                    Console.WriteLine($"{howMany * 1.25:f2}");
                }
                else if (product == "orange")
                {
                    Console.WriteLine($"{howMany * 0.90:f2}");
                }
                else if (product == "grapefruit")
                {
                    Console.WriteLine($"{howMany * 1.60:f2}");
                }
                else if (product == "kiwi")
                {
                    Console.WriteLine($"{howMany * 3.00:f2}");
                }
                else if (product == "pineapple")
                {
                    Console.WriteLine($"{howMany * 5.60:f2}");
                }
                else if (product == "grapes")
                {
                    Console.WriteLine($"{howMany * 4.20:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
