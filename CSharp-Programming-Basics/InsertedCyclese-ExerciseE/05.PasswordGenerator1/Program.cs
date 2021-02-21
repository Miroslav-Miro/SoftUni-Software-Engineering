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
            int count = 0;
            int count1 = 0;
            //char c1 = Convert.ToChar(c);
            //Console.WriteLine($"{a}{b}{c1}");
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 'a'; c < 'z'; c++)
                    {
                        count++;
                        //c2 = c - 100;
                        //j = j - j;
                        
                        if (count > 1)
                        {

                        }
                        else
                        {
                            c2 = Math.Abs(c - 100);
                        }
                        if (c2 > j)
                        {
                            break;
                        }
                        char c1 = Convert.ToChar(c);
                        for (int d = 'a'; d < 'z'; d++)
                        {
                            count1++;
                            //c2 = d - 100;
                            
                            // c2 = Math.Abs(c - 100);
                            if (count1 > 1)
                            {

                            }
                            else
                            {
                                c2 = Math.Abs(d - 100);
                            }
                            if (c2 > j)
                            {
                                break;
                            }
                            char d1 = Convert.ToChar(d);
                            for (int e = 1; e < n ; e++)
                            {
                                Console.WriteLine($"{a}{b}{c1}{d1}{e+1}");
                            }

                        }

                    }
                }
            }
        }
    }
}
