using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine($"{n} X {a} = {n * a}");
               
            }
            for (int i = a; i <= 10; i++)
            {
                if (a > 10)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }


        }
    }
}
