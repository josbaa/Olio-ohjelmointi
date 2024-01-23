using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    internal class Employee
    {
        // Fields
        public string Name;
        public int Id;
        public string Position;
        public double Salary;

        // Muodot
        public Employee(string name, int id, string position, double salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        // Vertaillaan ansioita/palkkaa
        public void CompareSalary(Employee otherEmployee)
        {
            if (Salary > otherEmployee.Salary)
                Console.WriteLine($"{Name} tienaa enemmän kuin {otherEmployee.Name}.");
            else if (Salary < otherEmployee.Salary)
                Console.WriteLine($"{Name} tienaa vähemmän kuin {otherEmployee.Name}.");
            else
                Console.WriteLine($"{Name} ja {otherEmployee.Name} tienaavat saman verran.");
        }

        // Employees
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Position: {Position}, Salary: {Salary:C}");
        }

        // ylikirjoitetaan
        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Position: {Position}, Salary: {Salary:C}";
        }
    }
}
