using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            // *0.82
            double oneSquareKilometer = 7.61;
            double kilometers = double.Parse(Console.ReadLine());

            double priceForAll = oneSquareKilometer * kilometers ;
            double discount = priceForAll * 0.18;
            double priceWithDiscount = priceForAll - discount;


            Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
