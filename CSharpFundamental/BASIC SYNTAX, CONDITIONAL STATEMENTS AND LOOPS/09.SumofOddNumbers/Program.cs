using System;

namespace _09.SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                    Console.WriteLine(i);
                    total += i;

                }
                if (count == n)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {total}");
        }
    }
}
