using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            //input
            double priceStrawBerry = double.Parse(Console.ReadLine());
            double kgBanana = double.Parse(Console.ReadLine());
            double kgOrange = double.Parse(Console.ReadLine());
            double kgRaspBerry = double.Parse(Console.ReadLine());
            double kgStrawBerry = double.Parse(Console.ReadLine());
            double priceRaspBerry = priceStrawBerry / 2;
            double priceOrange = (priceRaspBerry* 0.60);
            double priceBanana = priceRaspBerry * 0.20;

            //calculations
            double sumBanana = kgBanana * priceBanana;
            double sumOrange = kgOrange * priceOrange;
            double sumRaspBerry = kgRaspBerry * priceRaspBerry;
            double sumStrawBerry = kgStrawBerry * priceStrawBerry;
            double total = sumBanana + sumOrange + sumRaspBerry + sumStrawBerry;

            //output
            Console.WriteLine($"{total:f2}");
        }
    }
}
