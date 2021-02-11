using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (sellings <= 500)
                {
                    Console.WriteLine($"{sellings * 0.05:f2}");
                }
                else if (sellings <= 1000)
                {
                    Console.WriteLine($"{sellings * 0.07:f2}");
                }
                else if (sellings <= 10000)
                {
                    Console.WriteLine($"{sellings * 0.08:f2}");
                }
                else if (sellings >= 10000)
                {
                    Console.WriteLine($"{sellings * 0.12:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sellings <= 500)
                {
                    Console.WriteLine($"{sellings * 0.045:f2}");
                }
                else if (sellings <= 1000)
                {
                    Console.WriteLine($"{sellings * 0.075:f2}");
                }
                else if (sellings <= 10000)
                {
                    Console.WriteLine($"{sellings * 0.10:f2}");
                }
                else if (sellings >= 10000)
                {
                    Console.WriteLine($"{sellings * 0.13:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }


            }
            else if (city == "Plovdiv")
            {
                if (sellings>-1 &&sellings<= 500)
                {
                    Console.WriteLine($"{sellings * 0.055:f2}");
                }
                else if (sellings > -1 && sellings <= 1000)
                {
                    Console.WriteLine($"{sellings * 0.08:f2}");
                }
                else if (sellings > -1 && sellings <= 10000)
                {
                    Console.WriteLine($"{sellings * 0.12:f2}");
                }
                else if (sellings > -1 && sellings >= 10000)
                {
                    Console.WriteLine($"{sellings * 0.145:f2}");
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
