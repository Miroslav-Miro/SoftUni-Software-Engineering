using System;

namespace _05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int c2 = 0;
            //char c1 = Convert.ToChar(c);
            //Console.WriteLine($"{a}{b}{c1}");
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 'a'; c < 'z'; c++)
                    {

                        c2= Math.Abs(c - 100);
                        if (c > j)
                        {
                            break;
                        }
                       char c1 = Convert.ToChar (c);
                        Console.WriteLine($"{a}{b}{c1}");
                    }
                }
            }
        }
    }
}
