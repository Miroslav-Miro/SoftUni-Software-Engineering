using System;

namespace _05.PrintPart_OfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());

            for (int i = firstInt; i <= secondInt; i ++)
            {
                switch (i)
                {
                    case 60:
                        Console.Write('<');
                        break;
                    case 61:
                        Console.Write('=');
                        break;
                    case 62:
                        Console.Write('>');
                        break;
                    case 63:
                        Console.Write('?');
                        break;
                    case 64:
                        Console.Write('@');
                        break;
                    case 65:
                        Console.Write('A');
                        break;
                    case 69:
                        Console.Write('E');
                        break;
                    case 70:
                        Console.Write('F');
                        break;
                    case 71:
                        Console.Write('G');
                        break;
                    case 72:
                        Console.Write('H');
                        break;
                    case 73:
                        Console.Write('I');
                        break;
                    case 74:
                        Console.Write('J');
                        break;
                    case 75:
                        Console.Write('K');
                        break;
                    case 76:
                        Console.Write('L');
                        break;
                    case 77:
                        Console.Write('M');
                        break;
                    case 78:
                        Console.Write('N');
                        break;
                    case 79:
                        Console.Write('O');
                        break;
                    case 97:
                        Console.Write('a');
                        break;
                    case 98:
                        Console.Write('b');
                        break;
                    case 99:
                        Console.Write('c'); 
                        break;
                    case 100:
                        Console.Write('d');
                        break;
                    case 101:
                        Console.Write('e');
                        break;
                    case 102:
                        Console.Write('f');
                        break;
                    case 103:
                        Console.Write('g');
                        break;
                    case 104:
                        Console.Write('h');
                        break;
                    case 40:
                        Console.Write('(');
                        break;
                    case 41:
                        Console.Write(')'); //( ) * + , - . / 0 1 2 3 4 5 6 7
                        break;
                    case 42:
                        Console.Write('*');
                        break;
                    case 43:
                        Console.Write('+');
                        break;
                    case 44:
                        Console.Write(',');
                        break;
                    case 45:
                        Console.Write('-');
                        break;
                    case 46:
                        Console.Write('.');
                        break;
                    case 47:
                        Console.Write('/');
                        break;
                    case 48:
                        Console.Write('0');
                        break;
                    case 49:
                        Console.Write('1');
                        break;
                    case 50:
                        Console.Write('2');
                        break;
                    case 51:
                        Console.Write('3');
                        break;
                    case 52:
                        Console.Write('4');
                        break;
                    case 53:
                        Console.Write('5');
                        break;
                    case 54:
                        Console.Write('6');
                        break;
                    case 55:
                        Console.Write('7');
                        break;
                    default:
                        break;
                }
                Console.Write(" ");
            }
        }
    }
}
