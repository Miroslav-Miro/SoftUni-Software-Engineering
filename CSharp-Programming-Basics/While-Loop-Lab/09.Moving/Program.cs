using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int total = w * l * h;
            bool hasTotal = true;
           
            string done = Console.ReadLine();
            while (done != "Done")
            {
                int box = int.Parse(done);
                total -= box;
                if (total < 0)
                {
                    hasTotal = false;
                    break;
                }
                done = Console.ReadLine();

            }
            if (hasTotal)
            {
                Console.WriteLine($"{total} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(total)} Cubic meters more."
);
            }

        }
    }
}
