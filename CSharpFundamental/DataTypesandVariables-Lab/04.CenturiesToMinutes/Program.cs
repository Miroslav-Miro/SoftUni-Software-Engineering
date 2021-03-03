using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte centuries = byte.Parse(Console.ReadLine());
            //ushort years = ushort.Parse(Console.ReadLine());
            //uint days = uint.Parse(Console.ReadLine());
            byte centuries = byte.Parse(Console.ReadLine());


            
            int years = 0;
            int hours = 0;
            int minutes = 0;
            int dayss = 0;

            years = (ushort)(centuries * 100);
            dayss = (int)(years*365.2422);
            hours = dayss * 24;
            minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {dayss} days = {hours} hours = {minutes} minutes");


        }
    }
}
