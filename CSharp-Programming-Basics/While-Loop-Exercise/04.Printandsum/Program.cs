using System;

namespace _04.Printandsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = from; i <= to; i++)
            {
                Console.Write(i);
                total += i;
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {total}");
        }
    }
}
