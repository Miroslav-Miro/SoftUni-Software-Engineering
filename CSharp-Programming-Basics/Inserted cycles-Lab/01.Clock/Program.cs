using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 23; i++)
            {
                for (int a = 0; a <= 59; a++)
                {

                    Console.WriteLine($"{i}:{a}");
                    
                }
            }


        }
    }
}
