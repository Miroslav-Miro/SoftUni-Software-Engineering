using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double total = 0;

            if (typeOfGroup == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                    default:
                        break;
                }
                if (group >= 30)
                {
                    total = (price * group) * 0.15;

                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                    default:
                        break;
                }
                if (group >= 100)
                {
                    group -= 10;

                }

            }
            else if (typeOfGroup == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                    default:
                        break;
                }
                if (group >= 10 && group <= 20)
                {
                    total = (price * group) * 0.05;

                }
            }

            Console.WriteLine($"Total price: {(price * group) - total:f2}");



        }
    }
}
