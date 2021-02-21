using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNumber; i++)
            {
                int first = Convert.ToInt32(i.ToString().Substring(0, 1));
                int second = Convert.ToInt32(i.ToString().Substring(1, 1));
                int third = Convert.ToInt32(i.ToString().Substring(2, 1));
                int fourth = Convert.ToInt32(i.ToString().Substring(3, 1));
                int fifth = Convert.ToInt32(i.ToString().Substring(4, 1));
                int sixth = Convert.ToInt32(i.ToString().Substring(5, 1));

                if (first + third + fifth == second + fourth + sixth)
                {
                    Console.Write($"{i} ");
                }

                
                
            }


        }
    }
}
