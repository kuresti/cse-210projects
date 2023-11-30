using System;

class Program
{
    static void Main(string[] args)
    {
        Address customer1Address = new Address("145 N 3685 W", "South Jordan", "Utah", "USA");

        Customer customer1 = new Customer("Sara Jane", customer1Address);

        Console.WriteLine($"Customer Name: {customer1.Name}");
        Console.WriteLine($"{customer1.MailingAddress.GetAddressString()}");
        bool isDomestic = customer1.DomesticOrNot();
        Console.WriteLine($"Is Domestic: {isDomestic}");

        Product product1 = new Product("Socks", 1423, 3.00m, 4);
        Console.WriteLine($"Name: {product1.ProductName}\n ID: {product1.ProductID}, Price: ${product1.CalculatePrice()}");
    }

    
}