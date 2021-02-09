using System;

namespace _05.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string corectPass = "s3cr3t!P@ssw0rd";
            if (pass != corectPass)
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
