using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    even =even + number;
                }
                if (i%2 !=0)
                {
                    odd = odd + number;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                int diff = Math.Abs(even-odd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        } 
    }
}
