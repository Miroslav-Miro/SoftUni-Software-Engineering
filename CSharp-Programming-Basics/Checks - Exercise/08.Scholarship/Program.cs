using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());
            double excelent = 0;
            double excelent2 = 0;

            //Social scholarship NO
            if (income > minWage && grade < 4.50)
            {
                Console.WriteLine($"You cannot get a scholarship!");

            }
            //Social scholarship YES         
            else if (income < minWage && grade > 4.50)
            {
                excelent = minWage * 0.35;
                if (grade > 5.50)
                {
                    excelent2 = grade * 25;
                    if (excelent2 > excelent)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excelent2)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(excelent)} BGN");
                    }
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(excelent)} BGN");
                }
            }
            // Excelent grade 
            else if (grade >= 5.50)
            {
                excelent2 = grade * 25;
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excelent2)} BGN");
            }
            else if (grade < 5.50)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (income < minWage && grade > 4.50)
            {
                excelent = minWage * 0.35;
                Console.WriteLine($"You get a Social scholarship {Math.Floor(excelent)} BGN");
            }
            else if (income < minWage && grade > 4.50)
            {
                excelent = minWage * 0.35;
                if (grade > 5.50)
                {
                    excelent2 = grade * 25;
                    if (excelent2 > excelent)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excelent2)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(excelent)} BGN");
                    }
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(excelent)} BGN");
                }

            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }




        }
    }
}

