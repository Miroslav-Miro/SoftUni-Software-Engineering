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
            int countC = 0;
            int countD = 0;
           
            
            //char c1 = Convert.ToChar(c);
            //Console.WriteLine($"{a}{b}{c1}");
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 'a'; c <= 'z'; c++)
                    {
                        countC++;
                        if (countC <= 1)
                        {
                            c2 = c + j -1 ;
                        }
                        
                        if (c > c2)
                        {
                            break;
                        }
                        char c1 = Convert.ToChar(c);
                        for (int d = 'a'; d <= 'z'; d++)
                        {
                            countD++;
                            if (countD <= 1)
                            {
                                c2 = d + j -1 ;
                            }

                            
                            if (d > c2)
                            {
                                break;
                            }
                            char d1 = Convert.ToChar(d);
                            for (int e = 1; e < n; e++)
                            {
                                if (e+1 > a && e+1 > b)
                                {
                                    Console.Write($"{a}{b}{c1}{d1}{e + 1}");
                                    Console.Write(" ");
                                }
                                
                            }
                            //Console.Write(" ");
                        }
                        
                    }
                }
            }
        }
    }
}

