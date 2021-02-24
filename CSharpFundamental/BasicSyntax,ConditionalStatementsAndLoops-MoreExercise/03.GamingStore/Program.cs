using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double budget = double.Parse(Console.ReadLine());
            double total = budget;
            string name = "";


            while (true)
            {
                name = Console.ReadLine();
                if (name == "Game Time")
                {
                    break;
                }

                if (name == "OutFall 4")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 39.99;
                        Console.WriteLine($"Bought {name}");
                    }
                    
                    if (budget < 0)
                    {
                        
                    }
                }
                else if (name == "CS: OG")
                {
                    if (budget < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 15.99;
                        Console.WriteLine($"Bought {name}");
                    }

                    if (budget <= 0)
                    {
                        
                    }
                }
                else if (name == "Zplinter Zell")
                {
                    if (budget < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 19.99;
                        Console.WriteLine($"Bought {name}");
                    }

                    if (budget <= 0)
                    {
                        
                    }
                }
                else if (name == "Honored 2")
                {
                    if (budget < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 59.99;
                        Console.WriteLine($"Bought {name}");
                    }

                    if (budget <= 0)
                    {
                        
                    }
                }
                else if (name == "RoverWatch")
                {
                    if (budget < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 29.99;
                        Console.WriteLine($"Bought {name}");
                    }

                    if (budget <= 0)
                    {
                        
                    }
                }
                else if (name == "RoverWatch Origins Edition")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 39.99;
                        Console.WriteLine($"Bought {name}");
                    }

                    if (budget <= 0)
                    {
                        
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

            }
            if (budget <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${total - budget:f2}. Remaining: ${budget:f2}");
            }

        }
    }
}
