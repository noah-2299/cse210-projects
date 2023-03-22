using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address a1 = new Address("101-18643 52ND AVE", "SURREY", "BC", "CANADA");
        Customer c1 = new Customer("Linus", a1);
        Product cpu = new Product("Intel i9","X02JAMLA2",559.99,5);
        Product gpu = new Product("Radeon RX 6900","LA8AW20POJSDJH0-Q",649.99,5);
        Product storage = new Product("Samsung 980 Pro","HSAKJ82382993JS",79.98,2);
        Order order1 = new Order(c1);
        order1.AddProductToOrder(cpu);
        order1.AddProductToOrder(gpu);
        order1.AddProductToOrder(storage);
        // Order 2
        Address a2 = new Address("1600 Pennsylvania Avenue NW", "Washington", " DC", "USA");
        Customer c2 = new Customer("Mr. President",a2);
        Product pens = new Product("The Cross Classic Century ballpoint pen","000001",79.99,10);
        Product paper = new Product("Premium Stationary","X90X230",52.45,32);
        Product clips = new Product("Steel Paper Clips","KSAKS29320",0.05,1000);
        Order order2 = new Order(c2);
        order2.AddProductToOrder(pens);
        order2.AddProductToOrder(paper);
        order2.AddProductToOrder(clips);
        // Order 3
        Address a3 = new Address("Grafton Street", "Dublin", "D02 VF65", "Ireland");
        Customer c3 = new Customer("RAY-BAN", a3);
        Product sun = new Product("Sun Glasses","Bans-1",5.99,275);
        Product mens = new Product("Men Round Frame Glasses","Bans-27",2.99,275);
        Product womens = new Product("Womens Steel Frame","Bans-12",9.99,275);
        Order order3 = new Order(c3);
        order3.AddProductToOrder(sun);
        order3.AddProductToOrder(mens);
        order3.AddProductToOrder(womens);

        List<Order> orders = new List<Order>(){order1,order2,order3};
        foreach (Order order in orders){ 
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"TOTAL: ${order.CalculateTotal()}");
            Console.WriteLine("-------------------------------------------------------------");
        }

    }
}