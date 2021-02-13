using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int thiss = 0; 
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                thiss += a;
            }
            Console.WriteLine(thiss);
        }
    }
}
