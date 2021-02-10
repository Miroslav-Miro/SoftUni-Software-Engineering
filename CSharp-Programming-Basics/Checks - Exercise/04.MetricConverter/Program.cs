using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            if (from == "mm")
            {
                if (to == "m")
                {
                    Console.WriteLine($"{n/1000:f3}");
                }
                else if(to == "cm")
                {
                    Console.WriteLine($"{n/10:f3}");
                }
            }
            else if (from == "m")
            {
                if (to == "mm")
                {
                    Console.WriteLine($"{n * 1000:f3}");
                }
                else if (to == "cm")
                {
                    Console.WriteLine($"{n * 100:f3}");
                }
            }
            else if (from == "cm")
            {
                if (to == "mm")
                {
                    Console.WriteLine($"{n * 10:f3}");
                }
                else if (to == "m")
                {
                    Console.WriteLine($"{n / 100:f3}");
                }
            }
        }
    }
}
