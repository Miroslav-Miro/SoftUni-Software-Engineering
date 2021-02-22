using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double given = 0;
            
            
                while (true)
                {
                    string coin = Console.ReadLine();
                    if (coin == "Start")
                    {
                        break;
                    }
                    double coin1 = Convert.ToDouble(coin);
                    if (coin1 == 0.1 || coin1 == 0.2 || coin1 == 0.5 || coin1 == 1)
                    {
                        given += coin1;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coin}");
                    }

                }
                while (true)
                {
                    string command = (Console.ReadLine().ToLower());
                    if (command == "end")
                    {
                        break;
                    }

                    switch (command)
                    {
                        case "nuts":
                        if (given >= 2.0)
                        {
                            Console.WriteLine($"Purchased {command}");
                            given -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");                          
                        }   
                            break;
                        case "water":
                        if (given >= 0.7)
                        {
                            Console.WriteLine($"Purchased {command}");
                            given -= 0.7;
                            
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                        case "crisps":
                        if(given >= 1.5)
                        {
                            Console.WriteLine($"Purchased {command}");
                            given -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                        case "soda":
                        if (given >= 0.8)
                        {
                            Console.WriteLine($"Purchased {command}");
                            given -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                        case "coke":
                        if (given >= 1.0)
                        {
                            Console.WriteLine($"Purchased {command}");
                            given -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                }


            Console.WriteLine($"Change: { given:f2}");







        }
    }
}  

