using System;

namespace _06.Strongnumber
{
    class Program
    {
        static void Main(string[] args)
        {


            int numbers = int.Parse(Console.ReadLine());
            double total = 1;

                for (int i = 1; i <= numbers; i++)
                {
                   total *= i;
                   
                }
            Console.WriteLine(total);





        }
    }
}
