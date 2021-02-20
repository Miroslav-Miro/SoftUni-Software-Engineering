using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;
            int i = 0;
            int a = 0;


            for ( i = min; i <= max; i++)
            {
              
                for (a = min; a <= max; a++)
                {
                    count++;
                    if (i + a == magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {a} = {magicNum})");
                        return;
                    }
                    
                }
                
            }

            if (i + a != magicNum)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
            
          
            

            

        }
    }
}
