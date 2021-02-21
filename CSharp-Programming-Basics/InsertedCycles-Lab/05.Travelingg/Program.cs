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
            
            
            
            //string input = Console.ReadLine();

            while (true)
            {
                string destination = Console.ReadLine();
                
               
                if (destination == "End")
                {
                    break;
                }
                double minNeedMoney = double.Parse(Console.ReadLine());
                double total = 0;
                while (total < minNeedMoney)
                {
                    double saveMoney = double.Parse(Console.ReadLine());

                    total += saveMoney;
                }
                
                    Console.WriteLine($"Going to {destination}!");
                    
                    
                


            }





        }
    }
}
