using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Product : IProduct
    {
        public string name;
        public double price;
        public int count;

        public Product() 
        {
            this.name = string.Empty;
            this.price = 0;
            this.count = 0;
        }

        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }


        public double CalculateTotal()
        {
            return this.price * this.count;
        }

        public Product? GetProduct(string name)
        {
            if (this.name.ToLower() == name.ToLower().Replace(" " , ""))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public override string? ToString()
        {
            return $"{this.name}, {this.price} €, {this.count} kpl, varaston arvo {this.CalculateTotal()} €";
        }
    }
}
