using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    class Circle : Shape
    {
        double radius;

        // Konstruktori
        public Circle(double r)
        {
            radius = r;
        }

        // Ylikirjoitettu GetArea-metodi
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        // Ylikirjoitettu GetInfo-metodi
        public override void GetInfo()
        {
            Console.WriteLine($"Circle with radius {radius:F2}, area is {GetArea():F2}");
        }
    }
}