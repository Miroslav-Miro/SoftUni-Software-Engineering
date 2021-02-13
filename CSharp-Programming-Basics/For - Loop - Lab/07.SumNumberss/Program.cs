using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumNumberss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                int num= int.Parse(Console.ReadLine());
                number += num;
            }
            Console.WriteLine(number);
        }
    }
}
