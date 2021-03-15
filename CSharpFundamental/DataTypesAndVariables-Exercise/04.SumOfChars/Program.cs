using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                for (int a = letter; a <= letter; a++)
                {
                    total += a;
                }
            }
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}
