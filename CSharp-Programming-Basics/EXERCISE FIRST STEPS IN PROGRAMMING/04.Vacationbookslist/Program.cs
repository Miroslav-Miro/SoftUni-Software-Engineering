using System;

namespace _05.Birthdayparty
{ 
    class Program
    {
        static void Main(string[] args)
        {

            
            //input
            double taxRent = double.Parse(Console.ReadLine());

            //calculates
            double cake = taxRent * 20/ 100;
            double drinks = cake * 0.55;            
            double animator = taxRent / 3;
            double total =taxRent + cake + drinks + animator;
            
            Console.WriteLine($"{ total:f2}");
        }
    }
}
