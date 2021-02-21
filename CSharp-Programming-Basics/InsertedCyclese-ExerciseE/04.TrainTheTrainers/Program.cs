using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judge = int.Parse(Console.ReadLine());
            double totalMid = 0;
            double grade1 = 0;
            double grade2 = 0;
            double grade = 0;
            int count = 0;
            while (true)
            {
                string projectName = Console.ReadLine();
                
                if (projectName == "Finish")
                {
                    break;
                }
                count++;
                 grade1 = 0;
                for (int i = 0; i < judge; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    grade1 += grade;
                    grade2 += grade;
                   
                }
                double midGrade = grade1 / judge;
                Console.WriteLine($"{projectName} - {midGrade:f2}.");

            }
            totalMid = grade2 /(judge * count);
            Console.WriteLine($"Student's final assessment is {totalMid:f2}.");
        }
    }
}
