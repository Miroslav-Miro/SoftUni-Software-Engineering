using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            double minNeedMoney = 0;
            double total = 0;
            int times = 0;
            

            while (true)
            {
                times++;
                if (destination == "End")
                {
                    break;
                }
                else if (times == 1 || total >= minNeedMoney)
                {
                    destination = Console.ReadLine();
                    minNeedMoney = double.Parse(Console.ReadLine());
                    total = 0;
                }
                double saveMoney = double.Parse(Console.ReadLine());
                total += saveMoney;
               


            }
            




        }
    }
}
