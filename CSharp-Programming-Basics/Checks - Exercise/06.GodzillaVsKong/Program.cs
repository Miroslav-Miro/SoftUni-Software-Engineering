using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statists = double.Parse(Console.ReadLine());
            double priceForCostume = double.Parse(Console.ReadLine());
            double priceCostumeDis = 0;
            double all = 0;


            double priceDecoration = budget * 0.10;
            double priceAllCostume = statists * priceForCostume;
            if (statists > 150)
            {
                 priceCostumeDis = priceAllCostume * 0.10;
                priceAllCostume = priceAllCostume - priceCostumeDis;
                all = priceAllCostume + priceDecoration;
            }
            else
            {
                priceCostumeDis = priceAllCostume;
                all = priceCostumeDis + priceDecoration;
            }
            
            if (budget >= all)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget-all:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {all -budget:f2} leva more.");
            }
        }
    }
}
