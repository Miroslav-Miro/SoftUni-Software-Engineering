using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double liter = 0.001;
            //input
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            //calculatings
            double volumeAquarium = length * width * height;
            double liters = volumeAquarium * liter;
            double procents = procent * 0.01;
            double litersWhoNeed = liters * (1 - procents);

            //output
            Console.WriteLine(litersWhoNeed);



        }
    }
}
