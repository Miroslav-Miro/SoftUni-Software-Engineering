using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            
            for (int i = 1; i <= n*2; i++)
            {
             int input = int.Parse(Console.ReadLine());

                if (i <= n )
                {
                    left=left+ input ;
                    
                }
               else 
                {
                    right = right+ input;
                    
                }
            }


            if (left == right)
            {
                Console.WriteLine("Yes, sum = " + left);
            }
            else
            {
                int diff = Math.Abs(left - right);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
