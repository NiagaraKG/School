using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            do
            {
                int s = 0, i = 1;
                if (A == 1) { A++; }
                do
                {
                    if (A % i == 0) { s += i; }
                    i++;
                } while (i <= A / 2);
                if(s==A) { Console.WriteLine(A); }
                A++;
            } while (A <= B);
        }
    }
}
