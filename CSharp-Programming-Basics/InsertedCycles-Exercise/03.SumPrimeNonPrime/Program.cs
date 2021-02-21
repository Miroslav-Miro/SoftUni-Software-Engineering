using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "";
            
            
            int primeResult = 0;
            int nonPrimeResult = 0;
            while (true)
            {
                int a = 0;
                bool prime = false;
                bool notPrime = false;
                n = Console.ReadLine();
                if (n == "stop")
                {
                    break;
                }
                int result = Int32.Parse(n);
                
                for (int i = 1; i <= result; i++)
                {
                    if (result % i == 0)
                    {
                        a++;
                    }
                     
                }
               
                if (a == 2)
                {
                    prime = true;
                }
                else
                {
                    notPrime = true;
                }
                if (result < 0)
                {
                    Console.WriteLine("Number is negative.");
                    prime = false;
                    notPrime = false;
                }
                if (prime)
                {
                    primeResult += result;
                }
                else if (notPrime)
                {
                    nonPrimeResult += result;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeResult}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeResult}");
        }
    }
}
