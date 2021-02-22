using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                num = int.Parse(Console.ReadLine());

                num = Math.Abs(num);

                if (num % 2 == 0)
                {
                    break;
                }
                Console.WriteLine("Please write an even number.");
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
