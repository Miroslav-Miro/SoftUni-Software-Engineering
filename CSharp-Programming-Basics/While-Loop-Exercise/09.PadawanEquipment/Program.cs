using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double havedMoney = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lightsabersByOne = double.Parse(Console.ReadLine());
            double robesByOne = double.Parse(Console.ReadLine());
            double beltsByOne = double.Parse(Console.ReadLine());

            double total = 0;
            int count = 0;

            double moreSabers = students * 0.10;

            moreSabers = Math.Ceiling(moreSabers);
            total += (students + moreSabers) * lightsabersByOne;
            
            

            total += (students) * robesByOne;

            for (int i = 0; i < students; i++)
            {
                 count++;
                if (count == 6)
                {

                    count = 0;
                }
                else
                {
                    total += beltsByOne;
                }

                

            }
           


            

            if (total <= havedMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - havedMoney:f2}lv more.");
            }
        }
    }
}
