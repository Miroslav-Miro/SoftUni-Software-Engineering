using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;
            double max2 = double.MinValue;
            double min2 = double.MaxValue;
            double sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                //even
                if (i % 2 == 0)
                {
                    sum += num;
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
                //odd
                else if (i % 2 != 0)
                {
                    sum2 += num;
                    if (num> max2)
                    {
                        max2 = num;
                    }
                    if (num < min2)
                    {
                        min2 = num;
                    }
                }                            
            }
            Console.WriteLine($"OddSum={sum2 :f2},");
            if (n == 0 )
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else 
            {
                Console.WriteLine($"OddMin={min2:f2},");
                Console.WriteLine($"OddMax={max2:f2},");
            }
            Console.WriteLine($"EvenSum={sum:f2},");
            if (n == 0 || n == 1)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else 
            {
                Console.WriteLine($"EvenMin={min:f2},");
                Console.WriteLine($"EvenMax={max:f2}");
            }
        }
    }
}
