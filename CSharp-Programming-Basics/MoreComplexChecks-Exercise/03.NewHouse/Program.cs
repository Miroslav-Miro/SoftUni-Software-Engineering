using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int howMuch = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int Rosses = howMuch * 5;
            double Dah = howMuch * 3.80;
            double Tulips = howMuch * 2.80;
            double Nar = howMuch * 3;
            double Gla = howMuch * 2.50;

            double total = 0;

            if (typeFlowers == "Roses")
            {

                if (howMuch > 80)
                {
                    total = Rosses * 0.90;

                }
                else
                {
                    total = Rosses;
                }

            }
            else if (typeFlowers == "Dahlias")
            {

                if (howMuch > 90)
                {
                    total = Dah * 0.85;

                }
                else
                {
                    total = Dah;
                }




            }
            else if (typeFlowers == "Tulips")
            {

                if (howMuch > 80)
                {
                    total = Tulips * 0.85;

                }
                else
                {
                    total = Tulips;
                }

            }
            else if (typeFlowers == "Narcissus")
            {

                if (howMuch < 120)
                {
                    total = Nar * 1.15;

                }
                else
                {
                    total = Nar;
                }


            }
            else if (typeFlowers == "Gladiolus")
            {

                if (howMuch < 80)
                {
                    total = Gla * 1.20;

                }
                else
                {
                    total = Gla;
                }

            }
            double more = budget - total;
            double need = total - budget;
            if (total <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {howMuch} {typeFlowers} and {more:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {need:f2} leva more.");
            }
        }
    }
}
