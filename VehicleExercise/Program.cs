using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleExercise;

namespace VehicleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle Exercise!");

            Console.WriteLine("\nEmployee e");
            Employee e1 = new Employee("Antti Aho", "1234");
            Console.WriteLine("e.ToString(): " + e1);

            
            Console.WriteLine("\nEmployee boss");
            Employee e2 = new Employee("Seppo", "1234");
            Console.WriteLine("e2.ToString():" + e2.ToString());

            if (e1.Equals(e2))
                //if(e1 == e2)
            {
                Console.WriteLine($"{e1} ja {e2} ovat yhtäsuuria");
            }

            else
            {
                Console.WriteLine($"{e1} ja {e2} eivät ole yhtäsuuria");
            }

            Person p1 = new Person("Mikko Mallikas");
            Employee eTest = p1 as Employee;
            Console.WriteLine("onnistuuko eTest tulostus: " + eTest?.ToString());

            Person e1Test = e1 as Person;
            Console.WriteLine("onnistuuko e1 tulostus: " + e1?.ToString());



            Console.ReadLine();
        }
    }
}
