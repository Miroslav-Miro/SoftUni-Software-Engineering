using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            uint N = uint.Parse(Console.ReadLine());
            uint M = uint.Parse(Console.ReadLine());
            uint Y = uint.Parse(Console.ReadLine());
          
            uint goal = 0;
            double A = N * 0.50;

            while (N >= M )
            {
                N -= M;
                goal++;

                if (N == A && Y!=0)
                {                                      
                    N /= Y;                                                        
                }
                
            }
            Console.WriteLine(N);
            Console.WriteLine(goal);
        }
    }
}
