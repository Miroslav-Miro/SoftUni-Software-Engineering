using System;

namespace _08.PetShopp
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodForDog = 2.50;
            int otherFood = 4;
            int dogs = int.Parse(Console.ReadLine());
            int otherPets = int.Parse(Console.ReadLine());


            double dogsTotal = foodForDog * dogs;
            double otherTotal = otherFood * otherPets;
            double allTotal = dogsTotal + otherTotal;

            Console.WriteLine(allTotal+ " lv.");


        }
    }
}
