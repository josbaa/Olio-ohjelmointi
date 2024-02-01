using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExersise
{
    internal class Person
    {
        protected string name;

        public Person()
        {
            this.name = "N.N";
        }

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }
}

