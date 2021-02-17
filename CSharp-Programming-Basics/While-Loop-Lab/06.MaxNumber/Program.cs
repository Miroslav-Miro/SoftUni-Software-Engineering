using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.MaxValue; 
            //int max = int.MaxValue;

            while (input != "Stop" )
            {
                int num = int.Parse(input);
                
                if (num < n )
                {
                    n = +num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(n);
        }
    }
}
