using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string project = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double total = 0;

            if (project == "Premiere")
            {
                total= (rows * colums)*12;
                Console.WriteLine($"{total:f2} leva");
            }
            else if (project == "Normal")
            {
                total = (rows * colums) * 7.50;
                Console.WriteLine($"{total:f2} leva");
            }
            else if (project == "Discount")
            {
                total = (rows * colums) * 5;
                Console.WriteLine($"{total:f2} leva");
            }




        }
    }
}
