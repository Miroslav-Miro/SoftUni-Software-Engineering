using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int didigt = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string numbers =Console.ReadLine();

                for (int j = numbers.Length; j <= numbers.Length; j++)
                {
                    didigt = Convert.ToInt32(numbers);
                    didigt = (didigt%10);

                    switch (didigt)
                    {
                        case 2:
                            if (numbers.Length == 1)
                            {
                                result += "a";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "b";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "c";
                            }
                            break;
                        case 3:
                            if (numbers.Length == 1)
                            {
                                result += "d";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "e";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "f";
                            }
                            break;
                        case 4:
                            if (numbers.Length == 1)
                            {
                                result += "g";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "h";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "i";
                            }
                            break;
                        case 5:
                            if (numbers.Length == 1)
                            {
                                result += "j";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "k";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "l";
                            }
                            break;
                        case 6:
                            if (numbers.Length == 1)
                            {
                                result += "m";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "n";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "o";
                            }
                            break;
                        case 7:
                            if (numbers.Length == 1)
                            {
                                result += "p";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "q";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "r";
                            }
                            else if (numbers.Length == 4)
                            {
                                result += "s";
                            }
                            break;
                        case 8:
                            if (numbers.Length == 1)
                            {
                                result += "t";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "u";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "v";
                            }
                            break;
                        case 9:
                            if (numbers.Length == 1)
                            {
                                result += "w";
                            }
                            else if (numbers.Length == 2)
                            {
                                result += "x";
                            }
                            else if (numbers.Length == 3)
                            {
                                result += "y";
                            }
                            else if (numbers.Length == 4)
                            {
                                result += "z";
                            }
                            break;
                        case 0:
                            result += " ";
                            break;
                        default:
                            break;
                    }
                    
                }
            }
            Console.WriteLine(result);
        }
    }
}
