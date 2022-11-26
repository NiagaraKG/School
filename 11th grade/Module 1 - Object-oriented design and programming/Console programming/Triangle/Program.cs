
using System;

namespace ConsoleApp1
{
    public class triangle
    {
        private double a, b, c;
        public double A { get { return this.a; } }
        public double B { get { return this.b; } }
        public double C { get { return this.c; } }

        public double GetP() { return this.a + this.b + this.c; }
        public double GetS() { double p = this.GetP() / 2; return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c)); }

        public triangle(double a, double b, double c)
        {
            while (a <= 0) { Console.Write("Въведете положителна стойност на страната а: "); a = double.Parse(Console.ReadLine()); }
            this.a = a;
            while (b <= 0) { Console.Write("Въведете положителна стойност на страната b: "); b = double.Parse(Console.ReadLine()); }
            this.b = b;
            while (c >= a + b || c <= Math.Abs(a - b))
            {
                Console.Write($"Cтойносттa на страната c трябва да е в интервала ({Math.Abs(this.a - this.b)} ; {this.a + this.b}): ");
                c = double.Parse(Console.ReadLine());
            }
            this.c = c;
        }
    }


    class Program
    {
        static void PrintTriangle(triangle t)
        {
            Console.WriteLine("a = " + t.A);
            Console.WriteLine("b = " + t.B);
            Console.WriteLine("c = " + t.C);
            Console.WriteLine("P = {0:0.##}", t.GetP());
            Console.WriteLine("S = {0:0.##}", t.GetS());
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете страна a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Въведете страна b: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Въведете страна c: "); double c = double.Parse(Console.ReadLine());
            triangle t = new triangle(a, b, c);
            PrintTriangle(t);
        }
    }
}


