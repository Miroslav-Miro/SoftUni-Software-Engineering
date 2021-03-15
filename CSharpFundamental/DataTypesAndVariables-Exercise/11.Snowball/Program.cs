using System;
using System.Numerics;
namespace _11.Snowball
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            
            

            string last = string.Empty;

            BigInteger bestSnowballValue = -10000000000;




            for (int i = 0; i < N; i++)
            {
               
               int snowballSnow = int.Parse(Console.ReadLine());
               int  snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                //value = Math.Pow((snowballSnow / snowballTime), snowballQuality);

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue >=bestSnowballValue )
                {
                    bestSnowballValue = snowballValue;

                    last = $"{snowballSnow} : {snowballTime} = {bestSnowballValue} ({snowballQuality})";
                }
               
                
            }
            
            
                Console.WriteLine(last);
            
           
        }
    }
}
