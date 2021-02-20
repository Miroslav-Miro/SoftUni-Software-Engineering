using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room  = int.Parse(Console.ReadLine());


            for (int i = floor; i > 0; i--)
            {
                for (int a = 0; a < room; a++)
                {
                    
                    if (i == floor)
                    {
                       
                       
                        if (a == room- 1)
                        {
                            Console.WriteLine($"L{i}{a} ");
                        }
                        else
                        {
                            Console.Write($"L{i}{a} ");
                        }
                        

                    }

                    else if (i % 2 != 0)
                    {
                        if (a == room -1) //|| a == 2 || a == 3)
                        {
                            Console.WriteLine($"A{i}{a} ");
                        }
                        else
                        {
                            Console.Write($"A{i}{a} ");
                        }
                       
                        
                    }
                    else if (i % 2 == 0 )
                    {
                        if (a == room -1) //|| a == 2 || a == 3)
                        {
                            Console.WriteLine($"O{i}{a} ");
                        }
                        else
                        {
                            Console.Write($"O{i}{a} ");
                        }
                        
                        
                        
                    }
                    
                }
            }
        }
    }
}
