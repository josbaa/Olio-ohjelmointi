using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Store : ICustomers, IProducts
    {
        public string name;

        public List<Product> Products = new List<Product>();
        public List<Customer> Customers = new List<Customer>();

        public Store()
        {
            this.Products = new List<Product>();
            this.Customers = new List<Customer>();
            this.name = string.Empty;
        }

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        public string PrintCustomers()
        {
            throw new NotImplementedException();
        }

        public string PrintProduct()
        {
            throw new NotImplementedException();
        }

        void PrintProduts()
        {
            Console.WriteLine("Tuotteet");
            foreach (Product p in Products)
            {
                Console.WriteLine(p);
            }
        }
    }
   
}
