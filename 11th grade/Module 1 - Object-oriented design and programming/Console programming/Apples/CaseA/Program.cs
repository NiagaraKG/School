using System;

namespace CaseA
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2001;
            double tons = 20.00;
            while (tons<=50)
            {
                year++;
                if(year%2==0) { tons *= 1.2; }
            }
            Console.WriteLine(year);
        }
    }
}
