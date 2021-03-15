using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());

            double courses = people / capacity;

            courses = Math.Ceiling(courses);
            Console.WriteLine(courses);

            //second solution

            //int people = int.Parse(Console.ReadLine());
            //int capacity = int.Parse(Console.ReadLine());

            //int courses = 0;

            //while (people > 0)
            //{
            //    people -= capacity;
            //    courses++;
            //}
            //Console.WriteLine(courses);
        }
    }
}
