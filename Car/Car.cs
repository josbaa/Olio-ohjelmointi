using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{
    internal class Car
    {
        public string brand;
        public int speed;

        public Car()
        {
            this.brand = String.Empty;
            this.speed = 0;
        }

        public void AskData()
        {
            Console.Write("Auton merkki");
            this.brand = Console.ReadLine();

            //Console.Write("Auton nopeus");
            //string speedValue = Console.ReadLine();
            //int.TryParse(Console.ReadLine(), out this.speed);

            while (speed == 0)
            {
                Console.Write("Auton nopeus:");
                int.TryParse(Console.ReadLine(), out this.speed);
            }
        }

        public void ShowCarInfo()
        {

        }

        public void Accelerate(int value)

        {
            if (value < 0)
            {
                //pyydä uusi arvo
            }
            else
            {
                this.speed += value;
                Console.WriteLine($"Auton (this.brand) uusi nopeus on (this.speed)");
            }


        }

        internal void Brake()
        {
            throw new NotImplementedException();
        }

    }
}
