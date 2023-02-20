using System;

namespace Distance
{
    class Point
    {
        private double x, y;
        public double X { set { this.x = value; } get { return this.x; } }
        public double Y { set { this.y = value; } get { return this.y; } }
        public Point(double x, double y) { this.x = x; this.y = y; }
        public Point(Point B) { this.x = B.x; this.y = B.y; }
        public double Dist(Point B) { return Math.Sqrt(Math.Pow(this.x - B.X, 2) + Math.Pow(this.y - B.Y, 2)); }
        public bool CheckIfMatch(Point B)
        {
            if (Dist(B) == 0) { return true; }
            return false;
        }
        public Point Middle(Point B)
        {
            double x = (this.x + B.x) / 2, y = (this.y + B.y) / 2;
            Point M = new Point(x, y);
            return M;
        }
        public Point SymmetricTo(Point O)
        {
            double x2, y2;
            x2 = 2 * O.x - this.x;
            y2 = 2 * O.y - this.y;
            return new Point(x2, y2);
        }
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
            Point C = new Point(A);
            if (A.CheckIfMatch(B)) { Console.WriteLine("A и B съвпадат."); }
            else { Console.WriteLine("Разстоянието между A и B е: " + A.Dist(B)); }
            if (C.CheckIfMatch(B)) { Console.WriteLine("C и B съвпадат."); }
            else { Console.WriteLine("Разстоянието между C и B е: " + C.Dist(B)); }
            Point M = A.Middle(B);
            Console.WriteLine("M(" + M.X + ";" + M.Y + ")");
            Point N = A.SymmetricTo(M);
            Console.WriteLine("N(" + N.X + ";" + N.Y + ")");
        }
    }

}
