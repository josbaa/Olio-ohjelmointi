using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    abstract class Shape : IComparable<Shape>
    {
        // Konstruktori
        public Shape()
        {
        }

        // Abstrakti GetArea-metodi
        public abstract double GetArea();

        // Vertailu pinta-alan perusteella
        public int CompareTo(Shape other)
        {
            if (other == null) return 1;
            return this.GetArea().CompareTo(other.GetArea());
        }

        // Abstrakti GetInfo-metodi
        public abstract void GetInfo();
    }

}
