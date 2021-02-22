using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string output = "";

            if (name == "USA" || name == "England")
            {
                output = "England";
            }
            else if (name == "Argentina" || name == "Mexico" || name == "Spain")
            {
                output = "Spanish";
            }
            else
            {
                output = "unknown";
            }
            Console.WriteLine(output);
        }
    }
}
