using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int rows = 1; rows <= n; rows++) 
            {
                
                for (int i = 0; i < rows; i++)
                {
                    count++;
                    Console.Write($"{count} ");
                    if (count == n)
                    {
                        break;
                    }
                }
                if (count == n)
                {
                    break;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
