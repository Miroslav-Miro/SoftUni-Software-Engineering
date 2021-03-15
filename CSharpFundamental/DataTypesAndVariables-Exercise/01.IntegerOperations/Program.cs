using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            int onePlusTwo = one + two;
            int divide = onePlusTwo / three;
            int total = divide * four;

            Console.WriteLine(total);


        }
    }
}
