using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int minus = 0;


            for (int i = 0; i < n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook"  )
                {
                   
                    salary = salary - 150;
                }
                else if (site == "Instagram")
                {
                    
                    salary = salary - 100;
                }
                else if (site == "Reddit")
                {
                    
                    salary = salary - 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }
                
                                      
            }
            if (salary != 0)
            {
                Console.WriteLine($"{salary:f0}");
            }
            




        }
    }
}
