using System;

class Program
{
    static void Main(string[] args)
    {
        Address tomAddress = new Address("111 Hill Lane", "Spring Field", "Colorado", "USA");
        Customer tom = new Customer("Tom", tomAddress);

        Product bike = new Product("Bike", 1456, 100.50f, 3);
        Product helment = new Product("Helmet", 1457, 33.33f, 3);
        Order first = new Order(tom);
        first.AddProduct(bike);
        first.AddProduct(helment);


        Address heatherAddress = new Address("112 Hill Lane", "Toronto", "Ontario", "Canada");
        Customer heather = new Customer("Heather", heatherAddress);
        List<Product> heathersProducts = new List<Product>();
        Product motorcycle = new Product("Motorcycle", 1400, 1050.50f, 3);
        Product motorcycleHelment = new Product("Motorcycle Helment", 1401, 234.50f, 3);
        Product motorcycleSuit = new Product("Motorcycle Suit", 1402, 344.25f, 4);
        heathersProducts.Add(motorcycle);
        heathersProducts.Add(motorcycleHelment);
        heathersProducts.Add(motorcycleSuit);
        Order second = new Order(heather, heathersProducts);

        Display(first);
        Display(second);
    }

    static void Display(Order order)
    {
        Console.WriteLine("Packing Label:\n" + order.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order.TotalCost());
    }
}