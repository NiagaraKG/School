using System;

namespace CaseB
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 2000;
            double tons = 20.00, sum = 0;
            while (sum <= 900)
            {               
                if (g % 2 == 0 && g != 2000) { tons *= 1.2; }
                sum += tons;
                g++;
            }
            g--;
            Console.WriteLine(g);
        }
    }
}
