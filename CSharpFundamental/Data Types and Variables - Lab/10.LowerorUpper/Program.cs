using System;

namespace _10.LowerorUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char word = char.Parse(Console.ReadLine());
            
            
                if (Char.IsLower(word))
                    Console.WriteLine("lower-case");
                else if (Char.IsUpper(word))
                    Console.WriteLine("upper-case");

            
        }
    }
}
