using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFeaturesUsingMulticastDelegates
{
    public delegate void ComputeFeatures(double Height, double Width);
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(1.2, 2.4);
            ComputeFeatures rectFeatureComputeLogic = new ComputeFeatures(computeLogicArea);
            rectFeatureComputeLogic += new ComputeFeatures(computeLogicPerimeter);
            rect.compute(rectFeatureComputeLogic);
            Console.ReadKey();
        }

        public static void computeLogicArea(double Height, double Width)
        {
            Console.WriteLine("Area: {0}",Width * Height);
        }
        public static void computeLogicPerimeter(double Height, double Width)
        {
            Console.WriteLine("Perimeter: {0}", 2 * ( Width + Height ));
        }

    }
    class Rectangle
    {
        private double Height;
        private double Width;

        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public void compute(ComputeFeatures rectFeatureComputeLogic)
        {
            rectFeatureComputeLogic(this.Height, this.Width);
        }
    }
}
