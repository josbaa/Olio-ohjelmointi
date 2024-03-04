using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.AskData();
            car1.ShowCarInfo();

            //Lisätään nopeutta
            car1.Accelerate(40);
            car1.ShowCarInfo();

            car1.Brake();
            car1.ShowCarInfo();
        }
    }
}
