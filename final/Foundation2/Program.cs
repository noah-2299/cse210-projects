using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("101-18643 52ND AVE", "SURREY", "BC", "USA");
        Customer c1 = new Customer("Linus", a1);
        Product cpu = new Product("Intel i9","X02JAMLA2",559.99,5);
        Product gpu = new Product("Radeon RX 6900","LA8AW20POJSDJH0-Q",649.99,5);
        Product storage = new Product("Samsung 980 Pro","HSAKJ82382993JS",79.98,2);
        Order order1 = new Order(c1);
        order1.AddProductToOrder(cpu);
        order1.AddProductToOrder(gpu);
        order1.AddProductToOrder(storage);
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"TOTAL: ${order1.CalculateTotal()}");


    }
}