using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Circle : Shape
    {

        private double radius;

        public Circle (double radius)
        {
            this.radius = radius;
        }

        public override string GetInfo =>
            Console.WriteLine($"Circle with radius {this.radius}, Area: {GetArea()}");

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

   

        public override string? ToString()
        {
            return base.ToString();
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}