using System;

namespace _06.TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firstChar = Convert.ToChar('a' + i);
                for (int a = 0; a < n; a++)
                {
                    char second = (char)('a' + a);
                    for (int b = 0; b < n; b++)
                    {
                        char thirdChar = (char)('a' + b);
                        Console.WriteLine($"{firstChar}{second}{thirdChar}");
                    }
                }
            }
        }
    }
}
