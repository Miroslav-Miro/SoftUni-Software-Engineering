﻿using System;

namespace _08.TriangleofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(i+" ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
