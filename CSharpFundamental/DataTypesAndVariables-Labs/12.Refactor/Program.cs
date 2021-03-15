using System;

namespace _12.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            int output = 0;
            bool toe = false;
            for (int i = 1; i <= num; i++)
            {
                output = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                
                toe = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", output, toe);
                total = 0;
                i = output;
            }

        }
    }
}
