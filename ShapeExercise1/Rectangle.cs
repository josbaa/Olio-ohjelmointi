using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    class Rectangle : Shape
    {
        double length;
        double width;

        // Konstruktori
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        // Ylikirjoitettu GetArea-metodi
        public override double GetArea()
        {
            return length * width;
        }

        // Ylikirjoitettu GetInfo-metodi
        public override void GetInfo()
        {
            Console.WriteLine($"Rectangle with length {length:F2} and width {width:F2}, area is {GetArea():F2}");
        }
    }
}
