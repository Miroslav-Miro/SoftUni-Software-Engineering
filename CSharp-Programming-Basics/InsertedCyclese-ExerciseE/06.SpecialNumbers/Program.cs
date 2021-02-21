using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                 first = Convert.ToInt32(i.ToString().Substring(0, 1));
                 second = Convert.ToInt32(i.ToString().Substring(1, 1));
                 third= Convert.ToInt32(i.ToString().Substring(2, 1));
                 fourth = Convert.ToInt32(i.ToString().Substring(3, 1));
                if (first == 0 || second == 0 || third == 0 || fourth == 0)
                {
                      
                }
                else
                {
                    if (n % first == 0 && n % second == 0 && n % third == 0 && n % fourth == 0)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
