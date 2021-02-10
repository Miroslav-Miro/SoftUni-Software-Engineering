using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int deegre = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (deegre >= 10 && deegre <= 18)
            {
                if (time == "Morning")
                {
                    outfit = "Sweatshirt";
                    
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");
                }
                else if (time=="Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");

                }

            }
           else  if (deegre > 18 && deegre <= 24)
            {
                if (time == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");
                }
                else if (time == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");

                }

            }
            else if (deegre >= 25)
            {
                if (time == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");
                }
                else if (time == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deegre} degrees, get your {outfit} and {shoes}.");

                }

            }
        }
    }
}
