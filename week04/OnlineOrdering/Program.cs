using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main Street", "Seattle", "WA", "USA");
       
        Customer customer1 = new Customer("Dominic Toretto", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("God eyes Kit", "P1501", 25.50, 2);
        Product product2 = new Product("1970 Dodge Charger R/T Headlight", "P1702", 75.00, 1);
        Product product3 = new Product("Fast X Cap", "P1003", 8.99, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("====================================");
        Console.WriteLine("               ORDER 1              ");
        Console.WriteLine("====================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");


        Address address2 = new Address("39A Delta Avenue", "Badagry", "Lagos", "Nigeria");

        Customer customer2 = new Customer("Ayomide Stephen", address2);

        Order order2 = new Order(customer2);

        Product product4 = new Product("45-inch LG Television", "D2001", 299.99, 2);
        Product product5 = new Product("Electric Kettle", "D2022", 45.00, 3);
        Product product6 = new Product("Dell Laptop", "D6720", 150.09, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("====================================");
        Console.WriteLine("               ORDER 2              ");
        Console.WriteLine("====================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
    }
}