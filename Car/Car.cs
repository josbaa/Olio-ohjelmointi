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
            Console.Write("Auton merkki:");
            this.brand = Console.ReadLine();

            Console.Write("Auton nopeus:");
            int.TryParse(Console.ReadLine(), out this.speed);
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki: {this.brand}");
            Console.WriteLine($"Auton nopeus: {this.speed} km/h");
        }

        public void Accelerate(int change)
        {
            if (change < 0)
            {
                Console.WriteLine("Negatiivinen muutos ei ole sallittu.");
                return;
            }

            this.speed += change;
            Console.WriteLine($"Auton uusi nopeus: {this.speed} km/h");
        }

        public void Brake()
        {
            double decreasePercentage = 0.10; // 10% vähennys
            int decreaseAmount = (int)(this.speed * decreasePercentage);
            this.speed -= decreaseAmount;

            Console.WriteLine($"Auton nopeus vähennetty 10%: {this.speed} km/h");
        }
    }
}
