using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VehicleExersise
{
    internal class Employee: Person
    {
        
        private string id;

        public Employee()
        {
            this.id = "123456789";
        }

        public Employee(string name, string id) : base(name)
        {
            this.id = id;
        }

        public override bool Equals(object? obj)
        {
            Employee? other = obj as Employee;

            if (other == null)
                return false;

            if (this.name != other.name || this.id != other.id)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 1289958070;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{this.id}, {this.id}";

            //return $"{base.ToString()}, {this.id}";
        }
    }
}


