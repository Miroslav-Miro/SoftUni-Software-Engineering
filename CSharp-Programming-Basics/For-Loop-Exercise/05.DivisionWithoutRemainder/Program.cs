﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                

                if (num % 2 == 0 )
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
                

            }
            p1 = (p1 / n) * 100;
            p2 = (p2 / n) * 100;
            p3 = (p3 / n) * 100;
            
            

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
           


        }
    }
}
