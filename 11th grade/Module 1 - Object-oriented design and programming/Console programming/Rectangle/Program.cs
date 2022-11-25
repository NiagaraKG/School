using System;

namespace ConsoleApp1
{
    public class Rectangle
    {
        private double a;
        private double b;
        public double A
        {
            get { return this.a; }
            set
            {
                if (value > 0) { this.a = value; }
                else
                {
                    Console.Write("Невалидна стойност! Въведете нова стойност: ");
                    this.A = double.Parse(Console.ReadLine());
                }
            }
        }
        public double B
        {
            get { return this.b; }
            set
            {
                if (value > 0) { this.b = value; }
                else
                {
                    Console.Write("Невалидна стойност! Въведете нова стойност: ");
                    this.B = double.Parse(Console.ReadLine());
                }
            }
        }
        public double GetArea() { return this.a * this.b; }
        public double GetPerimeter() { return 2 * (this.a + this.b); }
        public double GetDiagonal() { return Math.Sqrt(this.a * this.a + this.b * this.b); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.Write("Въведете A: "); r.A = double.Parse(Console.ReadLine());
            Console.Write("Въведете B: "); r.B = double.Parse(Console.ReadLine());
            Console.WriteLine($"d = {r.GetDiagonal().ToString("0.##")}; P = {r.GetPerimeter()}; S = {r.GetArea().ToString("0.##")}");
        }
    }
}
