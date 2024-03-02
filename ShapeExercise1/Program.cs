
using ShapeExercise;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan heterogeeninen kokoelma
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(3));
            shapes.Add(new Rectangle(4, 5));
            shapes.Add(new Triangle(3, 4, 5));

            // Tulostetaan kokoelman sisältö
            Console.WriteLine("Shapes:");
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
            }

            // Lajitellaan muodot pinta-alan mukaan ja tulostetaan uudelleen
            Console.WriteLine("\nShapes after sorting by area:");
            shapes.Sort();
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
            }

            // Tulostetaan vain tietyn tyyppisten muotojen tiedot
            Console.WriteLine("\nOnly Triangles:");
            foreach (Shape shape in shapes)
            {
                if (shape.GetType() == typeof(Triangle))
                {
                    shape.GetInfo();
                }
            }

            // Vertailu värin perusteella
            Console.WriteLine("\nShapes sorted by color:");
            shapes.Sort((x, y) => x.GetType().Name.CompareTo(y.GetType().Name));
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
            }
        }
    }
   
}






