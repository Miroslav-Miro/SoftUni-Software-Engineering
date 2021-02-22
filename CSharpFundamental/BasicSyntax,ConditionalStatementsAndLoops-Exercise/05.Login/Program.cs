using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();
            string reverseString = "";
            int counter = 0;
            string user = originalString;
            bool end = false;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }

            while (true)
            {
                
                
                originalString = Console.ReadLine();
                counter++;

                if (originalString == reverseString)
                {
                    end = true;
                    break;
                    
                }
                else if (counter >= 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                    
                }
                Console.WriteLine("Incorrect password. Try again.");

                

                 
                

            }
            if (end)
            {
                Console.WriteLine($"User {user} logged in.");
            }
            
        }
    }
}
