using System;

namespace Point
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
            if (Math.Round(x1 / x2, 3) == Math.Round(y1 / y2, 3)) { Console.WriteLine("C лежи на правата, минаваща през A и B."); }
            else { Console.WriteLine("C не лежи на правата, минаваща през A и B."); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на точките: ");
            int n = int.Parse(Console.ReadLine()), m = 0;
            double min = double.MaxValue;
            Point O = new Point(0, 0);
            Point[] Arr = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете абсциса: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Въведете ордината: ");
                double y = double.Parse(Console.ReadLine());
                Arr[i] = new Point(x, y);
                if (min > Arr[i].Dist(O)) { min = Arr[i].Dist(O); m = i; }
            }
            Console.WriteLine($"Най-близка до центъра на координатната система е точката с координати ({Arr[m].X};{Arr[m].Y}), като разстянието от нея до центъра е {min}.");
        }
    }
}
