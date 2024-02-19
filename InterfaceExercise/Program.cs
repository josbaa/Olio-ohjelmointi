// See https://aka.ms/new-console-template for more information
using InterfaceExercise;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Product> list = new List<Product>()
{
    new Product("Haarukka", 1.99, 100),
    new Product("Veitsi", 2.10, 80),
    new Product("Lusikka", 2.50, 52)
};

List<Customer> customers = new List<Customer>()
{
    new Customer("Asiakas1", 20000),
    new Customer("Asiakas2", 30000),
    new Customer("Asiakas3", 30000),
    new Customer("Asiakas4", 30000)
};


foreach (Product product in list)
{
    if (product.GetProduct("Lusikka") != null)
    {
        Console.WriteLine("------");
        Console.WriteLine("Lusikka Löytyi");
        Console.WriteLine("Varaston arvo: " + product.CalculateTotal() + " €");
        Console.WriteLine("------");
    }
    Console.WriteLine(product);


    foreach (Customer customer in customers)
    {
        if (customer.GetCustomer("Asiakas1") != null) { Console.WriteLine("Found customer" + customer.name); }
        if (customer.GetCustomer("Asiakas1") != null) { Console.WriteLine("Found customer" + customer.name); }
        Console.WriteLine(customer);
    }

    Store s = new Store();
    s.AddProduct(new Product("kivi", 1.0, 100));
    s.AddProduct(new Product("naula", 2.0, 200));
}