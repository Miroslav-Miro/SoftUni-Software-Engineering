using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0;
            double howmuchGrade = 0;
            double bad = 0;
            double gardetotal = 0;

            while (howmuchGrade != 12)
            {
                grade = double.Parse(Console.ReadLine());
                howmuchGrade++;
                gardetotal += grade;
                if (grade < 4 )
                {
                    bad++;
                }
                if (bad >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {howmuchGrade-1} grade");
                    break;
                }
            }
            if (bad < 2)
            {
                gardetotal = gardetotal / howmuchGrade;
                Console.WriteLine($"{name} graduated. Average grade: {gardetotal:f2}");
            }
            
            

            
        }
    }
}
