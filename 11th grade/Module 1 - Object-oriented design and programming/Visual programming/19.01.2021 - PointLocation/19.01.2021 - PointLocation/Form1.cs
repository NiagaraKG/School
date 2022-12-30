using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._01._2021___PointLocation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Point
        {
            private double x, y;
            public double X { set { this.x = value; } get { return this.x; } }
            public double Y { set { this.y = value; } get { return this.y; } }
            public Point(double x, double y) { this.x = x; this.y = y; }
            public Point(Point B) { this.x = B.x; this.y = B.y; }
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            Point A = new Point(x, y);
            label4.Text += A.Quadrant();
        }
    }
}
