using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            double cakes = 45;
            double waffle = 5.80;
            double pancake = 3.20;

            //input
            double numDays = double.Parse(Console.ReadLine());
            double numOfBakers = double.Parse(Console.ReadLine());
            double numCakes = double.Parse(Console.ReadLine());
            double numWaffle = double.Parse(Console.ReadLine());
            double numPancake = double.Parse(Console.ReadLine());

            //calculation
            double sumCakes = cakes * numCakes; //630
            double sumWaffle = waffle * numWaffle; //174
            double sumPancake = pancake * numPancake; //51.2
            double sumPerDay = (sumCakes + sumWaffle + sumPancake) * numOfBakers;//6,841.6
            double fromAllCompani = sumPerDay * numDays;//157,356.8
            double total = fromAllCompani-(fromAllCompani / 8) ;
                


            //output
            Console.WriteLine(total);

        }
    }
}
