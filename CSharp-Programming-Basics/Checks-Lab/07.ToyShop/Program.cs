using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //stock
            double puzzle = 2.60;
            double talkingDoll = 3;
            double tedyBear = 4.10;
            double minion = 8.20;
            double truck = 2;

            //input
           double priceEcursion = double.Parse(Console.ReadLine());
            int numPuzzle = int.Parse(Console.ReadLine());
            int numDoll = int.Parse(Console.ReadLine());
            int numBear = int.Parse(Console.ReadLine());
            int numMinion = int.Parse(Console.ReadLine());
            int numTruck = int.Parse(Console.ReadLine());

            //calculations
            double amount = numPuzzle * puzzle + numDoll * talkingDoll + numBear * tedyBear + numMinion * minion + numTruck * truck;
            double numToys = numPuzzle + numDoll + numBear + numMinion + numTruck;

            if (numToys >= 50)
            {
                amount = amount * 0.75;
            }
                //double total = amount - discount;
                amount = amount * 0.9;
                //double profit = total - rent;
               // double residue = profit - priceEcursion;

               // Console.WriteLine($"Yes! {residue:f2} lv left.");
            
            if (amount >= priceEcursion)
            {
                double remainingMoney= amount - priceEcursion;
                Console.WriteLine($"Yes! { remainingMoney:F2} lv left.");
            }
            else if (amount <= priceEcursion)
            {
                double missingMoney =  priceEcursion - amount;
                Console.WriteLine($"Not enough money! {missingMoney:F2} lv needed.");
            }
        }
    }
}
