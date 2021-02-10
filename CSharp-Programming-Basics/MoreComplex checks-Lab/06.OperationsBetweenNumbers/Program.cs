using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            double total = 0;

            if ( N2==0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else if (operators=="+")
            {
                total = N1 + N2;
                if (total%2==0)
                {
                    Console.WriteLine($"{N1} + {N2} = {total} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {total} - odd");
                }
                
            }
            else if (operators == "-")
            {
                total = N1 - N2;
                if (total % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {total} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {total} - odd");
                }

            }
            else if (operators == "*")
            {
                total = N1 * N2;
                if (total % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {total} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {total} - odd");
                }

            }
            else if (operators =="/")
            {
                total =(double) N1 / N2;
                
                Console.WriteLine($"{N1} / {N2} = { total:f2}");
            }
            else if (operators =="%")
            {
                total = N1 % N2;
                Console.WriteLine($"{N1} % {N2} = {total}");
            }

        }
    }
}
