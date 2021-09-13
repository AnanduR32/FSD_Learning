using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2,4,5);
            Console.WriteLine("Triangle is of type \"{0}\"\nWith Area : {1}", triangle.TriangleType, triangle.Area());
            Console.ReadKey();
        }
    }
    abstract class Shapes
    {
        public double Width;
        public double Height;
        public double Radius;
        public double Side;
        public double Base;
        public double Side_1, Side_2, Side_3;
        public const float Pi = 22 / 7;
        public abstract double Area();
    }
    class Triangle : Shapes
    {
        public string TriangleType = "";
        public Triangle(double Side)
        {
            this.Side = Side;
            this.TriangleType = "Equilateral";
        }
        public Triangle(double Side_1, double Side_2, double Side_3)
        {
            this.Side_1 = Side_1;
            this.Side_2 = Side_2;
            this.Side_3 = Side_3;
            this.TriangleType = "Scalene";
        }
        public Triangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
            this.TriangleType = "Isosceles";
        }
        public override double Area()
        {
            if (this.TriangleType == "Equilateral")
            {
                return (Math.Pow(this.Side, 2) * Math.Pow(3, 0.5)) / 4;
            }
            else if (this.TriangleType == "Isosceles")
            {
                return (this.Base * this.Height) / 2;
            }
            else
            {
                double temp = (this.Side_1 + this.Side_2 + this.Side_3) / 3;
                return Math.Pow(temp * (temp - this.Side_1) * (temp - this.Side_2) * (temp - this.Side_3), 0.5);
            }
        }
    }
}
