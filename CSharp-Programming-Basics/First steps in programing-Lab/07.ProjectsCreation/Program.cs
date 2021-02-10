using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int proect = int.Parse(Console.ReadLine());
            int hours = 3;

            int resulthour = hours * proect;

            Console.WriteLine("The architect " + name + " will need " + resulthour + " hours to complete " + proect + " project/s.");
            
        
        }
    }
}
