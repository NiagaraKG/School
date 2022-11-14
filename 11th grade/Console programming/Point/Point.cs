using System;

namespace ConsoleApp1
{
    class Point
    {
        private double x, y;
        public double X { set { this.x = value; } get { return this.x; } }
        public double Y { set { this.y = value; } get { return this.y; } }
        public Point(double x, double y) { this.x = x; this.y = y; }
        public Point(Point B) { this.x = B.x; this.y = B.y; }
        public double Dist(Point B) { return Math.Sqrt(Math.Pow(this.x - B.X, 2) + Math.Pow(this.y - B.Y, 2)); }
        public bool CheckIfMatch(Point B) { return Dist(B) == 0; }
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
        public string Quadrant()
        {
            string location = "";
            if (this.x == 0)
            {
                if (this.y == 0) { location = "в центъра на координатната система."; }
                else { location = "върху ординатната ос."; }
            }
            else if (this.y == 0) { location = "върху абсцисната ос."; }
            else if (this.x > 0)
            {
                if (this.y > 0) { location = "в първи квадрант."; }
                else { location = "в четвърти квадрант."; }
            }
            else
            {
                if (this.y > 0) { location = "във втори квадрант."; }
                else { location = "в трети квадрант."; }
            }
            return location;
        }
        public void InLineWith(Point A, Point B)
        {
            double x1 = this.x - A.x;
            double y1 = this.y - A.y;
            double x2 = this.x - B.x;
            double y2 = this.y - B.y;
            if(Math.Round(x1/x2, 3) == Math.Round(y1 / y2, 3)) { Console.WriteLine("C лежи на правата, минаваща през A и B."); }
            else { Console.WriteLine("C не лежи на правата, минаваща през A и B."); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете координатите на A: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Point A = new Point(x, y);
            Console.WriteLine("Въведете координатите на B: ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Point B = new Point(x, y);
            Point A2 = new Point(A);
            if (A.CheckIfMatch(B)) { Console.WriteLine("A и B съвпадат."); }
            else { Console.WriteLine("Разстоянието между A и B е: " + A.Dist(B)); }
            if (A2.CheckIfMatch(B)) { Console.WriteLine("A2 и B съвпадат."); }
            else { Console.WriteLine("Разстоянието между A2 и B е: " + A2.Dist(B)); }
            Point M = A.Middle(B);
            Console.WriteLine("M(" + M.X + ";" + M.Y + ")");
            Console.WriteLine("Точката е разположена " + M.Quadrant());           
            Point N = A.SymmetricTo(M);
            Console.WriteLine("N(" + N.X + ";" + N.Y + ")");
            Console.WriteLine("Точката е разположена " + N.Quadrant());
            Console.WriteLine("Въведете координатите на C: ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Point C = new Point(x, y);
            C.InLineWith(A, B);
        }
    }
}
