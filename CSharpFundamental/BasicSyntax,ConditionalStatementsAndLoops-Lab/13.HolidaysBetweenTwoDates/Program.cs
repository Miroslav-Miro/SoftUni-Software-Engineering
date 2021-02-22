using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy"  ,CultureInfo.InvariantCulture,DateTimeStyles.None);
        var endDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        }
        Console.WriteLine(holidaysCount);
    }
}
