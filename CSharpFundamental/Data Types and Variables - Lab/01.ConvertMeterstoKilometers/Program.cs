﻿using System;

namespace _01.ConvertMeterstoKilometers
{
    class Program
    {
        static void Main(string[] args)
        {

            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0M;
            Console.WriteLine($"{kilometers:f2}");

        }   
    }
}
