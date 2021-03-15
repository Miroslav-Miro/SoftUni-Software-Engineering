using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            double r = 0;
            int h = 0;
            double volume = 0;
            double min = int.MinValue;
            string biggest = string.Empty;

            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                r = double.Parse(Console.ReadLine());
                h = int.Parse(Console.ReadLine());

                volume = 3.14 * (r * r) * h;

                if (volume > min)
                {
                    min = volume;
                    biggest = name;
                }

            }
            Console.WriteLine(biggest);
        }
    }
}
