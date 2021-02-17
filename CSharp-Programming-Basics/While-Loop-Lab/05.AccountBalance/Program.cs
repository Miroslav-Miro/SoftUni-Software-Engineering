using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            double total = 0;
            
            while (n != "NoMoreMoney")
            {
                 double money = double.Parse(n);
                                
                if (money < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }


                
                total += money;
                    Console.WriteLine($"Increase: {money:f2}");
                n = Console.ReadLine();


            }
            Console.WriteLine($"Total: {total:f2} ");

        }
    }
}
