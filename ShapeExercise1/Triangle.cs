using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    class Triangle : Shape
    {
        double a;
        double b;
        double c;

        // Konstruktori
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }

        // Ylikirjoitettu GetArea-metodi
        public override double GetArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        // Ylikirjoitettu GetInfo-metodi
        public override void GetInfo()
        {
            Console.WriteLine($"Triangle with sides {a:F2}, {b:F2}, and {c:F2}, area is {GetArea():F2}");
        }
    }

}
