using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Customer : ICustomer
    {
        public string name;
        public int purchases;
        public int bonus;

        public Customer(string name,int purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }


        public int GetBonus()
        {
            if (this.purchases > 0 && this.purchases < 1000) { return 2; }
            if (this.purchases >= 1000 && this.purchases < 2000) { return 3; }
            else { return 5; }
        }

        public Customer GetCustomer(string name)
        {
            if (this.name.ToLower() == name.ToLower())
                return this;
            return null;
        }

        public override string ToString()
        {
            return "Customer: name " + this.name + "\nPurchases " + this.purchases + "\nBonus" + this.GetBonus();
        }
    }
}
