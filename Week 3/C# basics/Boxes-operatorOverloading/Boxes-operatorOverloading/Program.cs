using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes_operatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(1.1f, 2.3f, 1.8f);
            Box b2 = new Box(1.2f, 2.4f, 1.5f);
            Box b3 = b1 + b2;
            b1.displayDimensions();
            b2.displayDimensions();
            b3.displayDimensions();
            Console.ReadKey();
        }
    }
    class Box
    {
        public float length, breadth, height;
        public Box(float length, float breadth, float height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }
        public void displayVolume()
        {
            Console.WriteLine("Volume = {0}",length * breadth * height);
        }
        public static Box operator +(Box b1, Box b2)
        {
            return new Box(
                b1.length + b2.length,
                b1.breadth + b2.breadth,
                b1.height + b2.height
                );
        }
        public void displayDimensions()
        {
            Console.WriteLine("{0} {1} {2}", length, breadth, height);
        }
    }

}
