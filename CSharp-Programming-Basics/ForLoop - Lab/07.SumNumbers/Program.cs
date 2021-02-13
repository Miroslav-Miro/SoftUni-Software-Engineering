using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int bigest = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a<smallest)
                {
                    smallest=a;
                }
                if (a>bigest)
                {
                    bigest=a;
                }
            }
            Console.WriteLine("Max number: " + bigest);
            Console.WriteLine("Min number: " + smallest);
        }
    }
}
