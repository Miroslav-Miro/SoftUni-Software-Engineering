using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            string text = Console.ReadLine(); //Set to TextBox text
            int[] numbers = new int[text.Length]; //Create array of ints
            for (int i = 0; i < text.Length; i++)
            {
                //Parse each character to an integer
                numbers[i] = Int32.Parse(text[i].ToString());

                total += numbers[i];
                
            }
            Console.WriteLine(total);
        }
    }
}
