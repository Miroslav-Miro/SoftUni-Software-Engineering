using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string input = Console.ReadLine(); 

            while (input!=pass )
            {
                input = Console.ReadLine();
                
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
