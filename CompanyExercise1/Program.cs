using CompanyExcercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company comp1 = new Company("Olvi Oyj", "Helsingntie 5", "43424242", 15000000, 12000000);

            Console.WriteLine(comp1.title);
            Console.WriteLine($"Voitto% on: {comp1.Calculateprofit():F2}");
            Console.ReadLine();
        }
    }
}
