using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine($"{i} * {a} = {i*a}");
                }
            }
        }
    }
}
