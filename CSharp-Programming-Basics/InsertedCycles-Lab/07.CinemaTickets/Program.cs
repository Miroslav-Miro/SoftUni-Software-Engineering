using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int emptyPlaces = int.Parse(Console.ReadLine());
            string ticket1 = Console.ReadLine();

            int tickeForFilm = 0;

            double totalTickets = 0;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidsTickets = 0;

            do
            {
               string ticket = ticket1;
                if (ticket == "student")
                {
                    studentTickets++;
                    totalTickets++;
                    tickeForFilm++;
                }
                else if (ticket == "standard")
                {
                    standardTickets++;
                    totalTickets++;
                    tickeForFilm++;
                }
                else if (ticket == "kid")
                {
                    kidsTickets++;
                    totalTickets++;
                    tickeForFilm++;
                }
                


                
                if (ticket1 == "End" )//||tickeForFilm  == emptyPlaces )
                {
                    double full = (100 / emptyPlaces) * tickeForFilm;
                    Console.WriteLine($"{name} - {full:f2}% full");
                    tickeForFilm = 0;
                    name = Console.ReadLine();
                     emptyPlaces = int.Parse(Console.ReadLine());
                    
                }
                else if (tickeForFilm == emptyPlaces)
                {
                    double full = (100 / emptyPlaces) * tickeForFilm;
                    Console.WriteLine($"{name} - {full:f2}% full");
                    tickeForFilm = 0;
                    name = Console.ReadLine();
                    emptyPlaces = int.Parse(Console.ReadLine());
                }
                if (ticket1 == "Finish")
                {
                    break;
                }
                ticket1 = Console.ReadLine();

            } while (ticket1 != "Finish");
            {
                studentTickets = (100 / totalTickets) * studentTickets;
                standardTickets = (100 / totalTickets) * standardTickets;
                kidsTickets = (100 / totalTickets) * kidsTickets;
                Console.WriteLine($"Total tickets: {totalTickets}");
                Console.WriteLine($"{studentTickets:f2}% student tickets.");
                Console.WriteLine($"{standardTickets:f2}% standard tickets.");
                Console.WriteLine($"{kidsTickets:f2}% kids tickets.");
            }

            
        }
    }
}
