﻿using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <= 2 )
            {
                Console.WriteLine("baby");
            }
            else if(n >= 3 && n <= 13 )
            {
                Console.WriteLine("child");
            }
            else if (n >= 14 && n <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (n >= 20 && n <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (n >= 66)
            {
                Console.WriteLine("elder");
            }
            

            
        }
    }
}
