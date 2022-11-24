using System;

namespace ConsoleApp1
{
    class Point
    {
        private double x, y;
        public double X { set { this.x = value; } get { return this.x; } }
        public double Y { set { this.y = value; } get { return this.y; } }
        public Point(double x, double y) { this.x = x; this.y = y; }
        public double Dist(Point B) { return Math.Sqrt(Math.Pow(this.x - B.X, 2) + Math.Pow(this.y - B.Y, 2)); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете координатите на A: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Point A = new Point(x1, y1);
            Console.WriteLine("Въведете координатите на B: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Point B = new Point(x2, y2);
            Console.WriteLine("Разстоянието между A и B е: " + A.Dist(B));
        }
    }
}
