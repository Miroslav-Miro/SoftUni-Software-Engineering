using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string star = Console.ReadLine();
            double totalPrice = 0;
           double totalPrice2 = 0;
            double days2 = 0;
            
            

            if (room == "room for one person")
            {
                days2 = days - 1;
                totalPrice = days2 * 18;
                if (star == "positive")
                {
                   totalPrice2= totalPrice * 0.25;
                    totalPrice = totalPrice + totalPrice2;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else
                {
                    totalPrice2 = totalPrice * 0.10;
                    totalPrice = totalPrice - totalPrice2;
                    Console.WriteLine($"{totalPrice:f2}");
                }
            }
            else if (room == "apartment")
            {
                if (days <= 10)
                {
                    days2 = days - 1;
                    totalPrice = days2 * 25;
                    totalPrice2 = totalPrice * 0.30;
                    totalPrice = totalPrice - totalPrice2;
                    if (star=="positive")
                    {
                        totalPrice2 = totalPrice * 0.25;
                        totalPrice = totalPrice + totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                    else
                    {
                        totalPrice2 = totalPrice * 0.10;
                        totalPrice = totalPrice - totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }

                }
                else if (days <=15)
                {
                    days2 = days - 1;
                    totalPrice = days2 * 25;
                    totalPrice2 = totalPrice * 0.35;
                    totalPrice = totalPrice - totalPrice2;
                    if (star == "positive")
                    {
                        totalPrice2 = totalPrice * 0.25;
                        totalPrice = totalPrice + totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                    else
                    {
                        totalPrice2 = totalPrice * 0.10;
                        totalPrice = totalPrice - totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                }
                else if (days > 15)
                {
                    days2 = days - 1;
                    totalPrice = days2 * 25;
                    totalPrice2 = totalPrice * 0.50;
                    totalPrice = totalPrice - totalPrice2;
                    if (star == "positive")
                    {
                        totalPrice2 = totalPrice * 0.25;
                        totalPrice = totalPrice + totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                    else
                    {
                        totalPrice2 = totalPrice * 0.10;
                        totalPrice = totalPrice - totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                }

            }
            else if (room == "president apartment")
            {
                if (days <= 10)
                {
                    days2 = days - 1;
                    totalPrice = days2 * 35;
                    totalPrice2 = totalPrice * 0.10;
                    totalPrice = totalPrice - totalPrice2;
                    if (star == "positive")
                    {
                        totalPrice2 = totalPrice * 0.25;
                        totalPrice = totalPrice + totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                    else
                    {
                        totalPrice2 = totalPrice * 0.10;
                        totalPrice = totalPrice - totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }

                }
                else if (days <= 15)
                {
                    days2 = days - 1;
                    totalPrice = days2 * 35;
                    totalPrice2 = totalPrice * 0.15;
                    totalPrice = totalPrice - totalPrice2;
                    if (star == "positive")
                    {
                        totalPrice2 = totalPrice * 0.25;
                        totalPrice = totalPrice + totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                    else
                    {
                        totalPrice2 = totalPrice * 0.10;
                        totalPrice = totalPrice - totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                }
                else if (days > 15)
                {
                    days2 = days - 1;
                    totalPrice = days2 * 35;
                    totalPrice2 = totalPrice * 0.20;
                    totalPrice = totalPrice - totalPrice2;
                    if (star == "positive")
                    {
                        totalPrice2 = totalPrice * 0.25;
                        totalPrice = totalPrice + totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                    else
                    {
                        totalPrice2 = totalPrice * 0.10;
                        totalPrice = totalPrice - totalPrice2;
                        Console.WriteLine($"{totalPrice:f2}");
                    }
                }

            }


        }  
    }
}
