﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {

            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "f")
            {
                if (age < 16 )
                {
                    Console.WriteLine($"Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (age < 16)
                {
                    Console.WriteLine($"Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
