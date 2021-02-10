using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (n > 1000)
            {
                if (n % 2 == 0)
                {
                    bonus = n*0.10;
                    Console.WriteLine(bonus+1);
                    Console.WriteLine(n + bonus + 1);
                }
                else if (n % 5 == 0)
                {
                    bonus = n*0.10;
                    Console.WriteLine(bonus+2);
                    Console.WriteLine(n + bonus + 2);
                }
                else
                {
                    bonus = n*0.10;
                    Console.WriteLine(bonus);
                    Console.WriteLine(n + bonus);
                }
            }
            else if (n > 100)
            {
                if (n % 2 == 0)
                {
                    bonus = n*0.20;
                    Console.WriteLine(bonus+1);
                    Console.WriteLine(n + bonus + 1);
                }
                else if (n % 5 == 0)
                {
                    bonus = n*0.20;
                    Console.WriteLine(bonus+2);
                    Console.WriteLine(n + bonus + 2);
                }
                else
                {
                    bonus = n*0.20;
                    Console.WriteLine(bonus);
                    Console.WriteLine(n + bonus);
                }
            }
            else
            {
                if (n%2==0)
                {
                    bonus = 5;
                    Console.WriteLine(bonus+1);
                    Console.WriteLine(n + bonus+1);
                }
                else if(n%5==0)
                {
                    bonus = 5;
                    Console.WriteLine(bonus+2);
                    Console.WriteLine(n + bonus+2);
                }
                else
                {
                    bonus = 5;
                    Console.WriteLine(bonus);
                    Console.WriteLine(n + bonus);
                }
                
            }
        }
    }
}
