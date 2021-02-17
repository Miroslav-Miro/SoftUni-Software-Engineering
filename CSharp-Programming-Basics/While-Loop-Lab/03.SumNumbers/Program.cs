using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;

            while (true)
            {
              int sum = int.Parse(Console.ReadLine());
                
                 sum1 += sum;
                if (sum1 >= n)
                {
                    Console.WriteLine(sum1);
                    break;
                }
                
            }
            
        }
    }
}
