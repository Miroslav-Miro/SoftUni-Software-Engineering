using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.MinValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (num > n)
                {
                    n = +num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(n);
        }
    }
}
