using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());

            if (sec >= 45)
            {
                double more = sec - 45;
                sec = 00 + more;
                if (min >= 23)
                {
                    
                    if (sec < 10)
                        
                    {
                        min = 00;
                        Console.WriteLine($"{min}:0{sec}");
                    }
                    else
                    {
                        min = 00;
                        Console.WriteLine($"{min}:{sec}");
                    }
                }
                else
                {
                   
                    if (sec < 10 )
                    {
                        Console.WriteLine($"{min + 1}:0{sec}");
                    }
                    else
                    {
                        Console.WriteLine($"{min+1 }:{sec}");
                    }
                }

            }
            else
            {
                
                if (sec < 10 && sec > 010)
                {
                    Console.WriteLine($"{min }:0{sec + 15}");
                }
                else
                {
                    Console.WriteLine($"{min }:{sec + 15}");
                }
            }
        }
    }
}
