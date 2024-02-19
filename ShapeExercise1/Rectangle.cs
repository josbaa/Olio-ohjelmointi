using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Rectangle : Shape
    {
        private double width;
        private double height;


        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string GetInfo => Console.WriteLine($"Rectangle with width {width} and height {height}, Area: {GetArea()}");

        public override double GetArea()
        {
            return width * height;
        }
    }
}
