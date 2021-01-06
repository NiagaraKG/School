using System;

namespace ConsoleApp2
{
    class Rational
    {
        private int num, denum;
        public int Num { set { this.num = value; } get { return this.num; } }
        public int Denum
        {
            get { return this.denum; }
            set
            {
                if (value != 0) { this.denum = value; }
                else { Console.Write("Знаменателят трябва да е различен от 0. Въведете валидна стойност: "); this.Denum = int.Parse(Console.ReadLine()); }
            }
        }
        public Rational(int x, int y)
        {
            this.num = x;
            while (y == 0) { Console.Write("Знаменателят трябва да е различен от 0. Въведете валидна стойност: "); y = int.Parse(Console.ReadLine()); }
            this.denum = y;
        }
        public Rational(Rational B) { this.num = B.num; this.denum = B.denum; }
        public void Print() { Console.Write(this.num + "/" + this.denum); }
        public void Simplify()
        {
            if (num != 0)
            {
                int num1 = Math.Abs(this.num), denum1 = Math.Abs(this.denum);
                while (num1 != denum1) { if (num1 > denum1) { num1 -= denum1; } else { denum1 -= num1; } }
                if (num != 1) { this.num /= num1; this.denum /= num1; }
            }
            this.Norm();
        }
        public void Norm() { if (this.denum < 0) { this.num = -this.num; this.denum = -this.denum; } }
        public Rational MultiplyBy(Rational B)
        {
            Rational C = new Rational(this.num * B.num, this.denum * B.denum);
            C.Simplify();
            return C;
        }
        public Rational Reverse() { Rational P = new Rational(this.denum, this.num); return P; }
        public Rational DivideBy(Rational B)
        {
            Rational C = B.Reverse();
            C = this.MultiplyBy(C);
            C.Simplify();
            return C;
        }
        public Rational SumWith(Rational B)
        {
            Rational S = new Rational(this.num*B.denum + this.denum*B.num,this.denum*B.denum);
            S.Simplify();
            return S;
        }
        public Rational Opposite()
        { return new Rational(-this.num, this.denum); }
        public Rational Subtract(Rational B)
        {
            Rational C = B.Opposite();
            C = this.SumWith(C);
            C.Simplify();
            return C;
        }
        public void PrintDecimal() { Console.WriteLine("{0:0.###}", (float)this.num/this.denum); }
        public void PrintImproper()
        {
            
            if (this.num % this.denum == 0) { Console.Write(this.num/this.denum); }
            else if(this.num < this.denum) { this.Print(); }
            else { Console.Write("{0} {1}/{2}", this.num/this.denum, this.num%this.denum, this.denum); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете числител: "); int num = int.Parse(Console.ReadLine());
            Console.Write("Въведете знаменател: "); int denum = int.Parse(Console.ReadLine());
            Rational a = new Rational(num, denum);
            a.Print();
            Console.Write(" = ");
            a.Simplify();
            a.PrintImproper();
            Console.WriteLine();
            Console.Write("Въведете числител: "); num = int.Parse(Console.ReadLine());
            Console.Write("Въведете знаменател: "); denum = int.Parse(Console.ReadLine());
            Rational b = new Rational(num, denum);
            b.Print();
            Console.Write(" = ");
            b.Simplify();
            b.PrintImproper();
            Console.WriteLine();
            a.PrintImproper();
            Console.Write(" * ");
            b.PrintImproper();
            Console.Write(" = ");
            Rational c = a.MultiplyBy(b);
            c.PrintImproper();
            Console.WriteLine();
            a.PrintImproper();
            Console.Write(" : ");
            b.PrintImproper();
            Console.Write(" = ");
            c = a.DivideBy(b);
            c.PrintImproper();
            Console.WriteLine();
            a.PrintImproper();
            Console.Write(" + ");
            b.PrintImproper();
            Console.Write(" = ");
            c = a.SumWith(b);
            c.PrintImproper();
            Console.WriteLine();
            Console.Write("Противоположната дроб на първата въведена е: ");
            c = a.Opposite();
            c.PrintImproper();
            Console.WriteLine();
            a.PrintImproper();
            Console.Write(" - ");
            b.PrintImproper();
            Console.Write(" = ");
            c = a.Subtract(b);
            c.PrintImproper();
            Console.WriteLine();
            Console.Write("Десетичното представяне на първата дроб е: ");
            a.PrintDecimal();
        }
    }
}
