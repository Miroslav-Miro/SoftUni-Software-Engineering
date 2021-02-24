using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] charArray = text.ToCharArray();

            Array.Reverse(charArray);

            string newString = "";

            foreach (char tempChar in charArray)
            {
                newString += tempChar;
            }
            Console.WriteLine(newString);
        }
    }
}
