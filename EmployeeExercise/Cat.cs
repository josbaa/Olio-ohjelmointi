using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExercise
{
    internal class Cat
    {
        public string name;
        public int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"kissan nimi: {this.name}; ikä: {this.age}";
        }
        internal void CompareAge(Cat cat)
        {
            Console.WriteLine($"{this.name}");
            Console.WriteLine($"{cat.name}");
        }

        internal void CompareCats(Cat cat)
        {
            throw new NotImplementedException();
        }
    }
}
