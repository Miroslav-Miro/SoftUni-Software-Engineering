using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal counter = 0;

            for (int i = 0; i < n; i++)
            {
                decimal n1 = decimal.Parse(Console.ReadLine());

                 counter += n1;
            }
            Console.WriteLine(counter);
        }
    }
}
