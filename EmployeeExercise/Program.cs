using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // olioin luontia
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Kari Pari", 1, "Maestro", 50000);
            employees[1] = new Employee("Anu Kakko", 2, "Päällikkö", 45000);
            employees[2] = new Employee("Marli Jauhonen", 3, "Pohjakerros", 20000);

            // tulostaa työntekijöitä
            foreach (Employee employee in employees)
            {
                employee.PrintEmployeeInfo();
            }

            // palkkavertailua
            for (int i = 0; i < employees.Length; i++)
            {
                Employee nextEmployee = (i == employees.Length - 1) ? employees[0] : employees[i + 1];
                employees[i].CompareSalary(nextEmployee);
            }
        }
    }
}
