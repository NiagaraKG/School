using System;

namespace ConsoleApp1
{
    public class Car
    {
        private string brand;
        private string model;
        private int engineVolume;
        private int yearProd;

        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public int EngineVolume
        {
            set
            {
                if (value > 0) { engineVolume = value; }
                else
                {
                    Console.Write("Некоректна стойност! Въведете повторно: ");
                    this.EngineVolume = int.Parse(Console.ReadLine());
                }
            }
            get { return engineVolume; }
        }
        public int YearProd
        {
            set
            {
                if (value >= 1900 && value <= 2020) { this.yearProd = value; }
                else
                {
                    Console.Write("Некоректна стойност! Въведете повторно: ");
                    this.YearProd = int.Parse(Console.ReadLine());
                }
            }
            get { return yearProd; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.Write("Въведете марка: ");
            myCar.Brand = Console.ReadLine();
            Console.Write("Въведете модел: ");
            myCar.Model = Console.ReadLine();
            Console.Write("Въведете обем на двигателя: ");
            myCar.EngineVolume = int.Parse(Console.ReadLine());
            Console.Write("Въведете година на производство: ");
            myCar.YearProd = int.Parse(Console.ReadLine());
            Console.WriteLine(myCar.Brand + " " + myCar.Model + ", " + myCar.EngineVolume + ", " + myCar.YearProd);
        }
    }
}
