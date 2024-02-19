// See https://aka.ms/new-console-template for more information
using ShapeExercise;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{

    internal class Program : Shape
    {
        public Program()
        {

        }

        private static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Shape c1 = new Circle("Punainen", 3.2);
            Shape c2 = new Triangle("Sininen", 3.6);
            Shape c3 = new Rectangle("Keltainen", 11);

            foreach (Shape s in list)
            {

                s.GetArea();
            }
            Console.ReadLine();
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}






