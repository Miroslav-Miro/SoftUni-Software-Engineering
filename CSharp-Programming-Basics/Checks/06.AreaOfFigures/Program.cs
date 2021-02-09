using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
           string input= Console.ReadLine();

            if (input == "square")
            {
                double numSquare = double.Parse(Console.ReadLine());
                double area = numSquare * numSquare;
                Console.WriteLine($"{area:f3}");
            }
            else if (input == "rectangle")
            {
                double sideLenght = double.Parse(Console.ReadLine());
                double sideLenght2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideLenght * sideLenght2:f3}");
            }
            else if (input == "circle")
            {
                double p = 3.14159;
                double radius = double.Parse(Console.ReadLine());
                double area = p * (radius * radius);

                Console.WriteLine($"{area:f3}");
            }
            else if (input == "triangle")
            {
                double baseTriangle = double.Parse(Console.ReadLine());
                double heigh = double.Parse(Console.ReadLine());
                double area = 0.5 * baseTriangle * heigh;
                Console.WriteLine($"{area:f3}");

            }

        }
    }
}
