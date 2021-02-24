using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int lower = 0; //int.MaxValue;
            int higer = 0; //int.MinValue;
            int medium = 0;

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            

            for (int i = 1; i <= 3; i++)
            {
                
                int a = int.Parse(Console.ReadLine());


                if (n1 == 0)
                {
                    n1 = a;
                }
                else if (n2 == 0 )
                {
                    n2 = a;
                }
                else if (n3 == 0 )
                {
                    n3 = a;
                }
            }
            if (n1 <= n2 && n1 <= n3)
            {
                lower = n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                lower = n2;
            }
            else if (n3 <= n1 && n3 <= n2)
            {
                lower = n3;
            }
            if (n1 <= n3 && n2 <= n3)
            {
                higer = n3;
            }
            else if (n2 <= n1 && n3 <= n1)
            {
                higer = n1;
            }
            else if (n1 <= n2 && n3 <= n2)
            {
                higer = n2;
            }
            if (n1 < 0 || n2 < 0|| n3<0)
            {
                if (n1 == higer)
                {
                    medium = n1;
                }
                else if (n2 == higer)
                {
                    medium = n2;
                }
                else if (n3 == higer)
                {
                    medium = n3;
                }
            }
           

            else if (n1 <= 0 || n2 <= 0 || n3 <= 0)
            {
                if (n1 > lower && n1 < higer)
                {
                    medium = n1;
                }
                else if (n2 > lower && n2 < higer)
                {
                    medium = n2;
                }
                else if (n3 > lower && n3 < higer)
                {
                    medium = n3;
                }
            }
            else
            {
                if (n1 >= lower && n1 < higer)
                {
                    medium = n1;
                }
                else if (n2 >= lower && n2 <= higer)
                {
                    medium = n2;
                }
                else if (n3 >= lower && n3 <= higer)
                {
                    medium = n3;
                }
            }
            


            Console.WriteLine(higer);
            Console.WriteLine(medium);
            Console.WriteLine(lower);







           
        }
    }
}
