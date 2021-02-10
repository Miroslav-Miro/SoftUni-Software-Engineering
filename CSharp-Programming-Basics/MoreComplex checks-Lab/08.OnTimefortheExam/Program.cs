using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourCome = int.Parse(Console.ReadLine());
            int minCome = int.Parse(Console.ReadLine());

            int timeExam =hourExam*60+minExam;
            int timeCome = hourCome*60+minCome;

            int diff = timeExam -timeCome;
        }
    }
}
