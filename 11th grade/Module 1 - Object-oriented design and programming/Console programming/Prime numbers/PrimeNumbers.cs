using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            do
            {
                int i = 2, br = 0;
                do
                {
                    if (A % i == 0) { br++; break; }
                    i++;
                } while (i <= Math.Sqrt(A));
                if(br==0) { Console.WriteLine(A); }
                A++;
            } while (A<=B);
        }
    }
}
