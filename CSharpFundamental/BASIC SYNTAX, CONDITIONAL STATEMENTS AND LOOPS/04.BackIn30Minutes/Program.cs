using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int nextMin = 0;
            int total = min + 30;

            if (total > 59)
            {
                nextMin = min - 30;
                
                if (hour == 23)
                {
                    if (nextMin < 10)
                    {
                        Console.WriteLine($"{0}:0{nextMin}");
                    }
                    else
                    {
                        Console.WriteLine($"{0}:{nextMin}");
                    }
                    
                }
                else if (nextMin < 10)
                {
                    Console.WriteLine($"{hour + 1}:0{nextMin}");
                }
                else
                {
                    Console.WriteLine($"{hour + 1}:{nextMin}");
                }


            }
            else
            {
                Console.WriteLine($"{hour}:{min + 30}");
            }
        }
    }
}
