using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int dispalyCount = 0;


            int counterForMouse = 0;
            int counterForKeyboard = 0;
            int counterFotMouseToKey = 0;

            for (int i = 1; i <= lostGame; i++)
            {
                counterForMouse++;
                if (i % 2 == 0)
                {
                    headsetCount++;
                    counterFotMouseToKey++;
                }

                if (counterForMouse == 3)
                {
                    mouseCount++;
                    counterForMouse = 0;
                   
                }

                if (i % 2 == 0 && counterFotMouseToKey == 3)
                {
                    counterForKeyboard++;
                    keyboardCount++;
                    counterFotMouseToKey = 0;
                }

                if (counterForKeyboard == 2)
                {
                    dispalyCount++;
                    counterForKeyboard = 0;
                }
            }
            double total = headsetPrice * headsetCount + mousePrice * mouseCount + keyboardPrice * keyboardCount + displayPrice * dispalyCount;

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
