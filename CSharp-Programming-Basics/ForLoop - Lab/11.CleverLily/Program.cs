using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            double priceForToys = double.Parse(Console.ReadLine());
            double saveMoney = 10;
            int toys = 0;
            int brother = 0;
            double save = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0 )
                {
                    toys++;
                }
                else if (i % 2 == 0)
                {
                    save = saveMoney + save;

                    saveMoney = saveMoney + 10;

                    brother++;
                }
            }
            saveMoney = save-brother + (toys * priceForToys);
            if (saveMoney >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {saveMoney - priceOfWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceOfWashingMachine - saveMoney:f2}");
            }
        }
    }
}
