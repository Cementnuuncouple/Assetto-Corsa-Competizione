using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public string Customer { get; set; }
    public double Amount { get; set; }

    public Order(string customer, double amount)
    {
        Customer = customer;
        Amount = amount;
    }
}

class OrderManager
{
    private readonly List<Order> orders = new();

    public void AddOrder(string customer, double amount)
    {
        orders.Add(new Order(customer, amount));
    }

    public void PrintReport()
    {
        Console.WriteLine("Order Report");
        Console.WriteLine("============");

        foreach (var order in orders)
        {
            Console.WriteLine($"{order.Customer} | ${order.Amount:F2}");
        }

        double total = orders.Sum(order => order.Amount);

        Console.WriteLine("============");
        Console.WriteLine($"Total Revenue: ${total:F2}");
    }
}

class Program
{
    static void Main()
    {
        var manager = new OrderManager();

        manager.AddOrder("Alice", 125.50);
        manager.AddOrder("Brian", 89.99);
        manager.AddOrder("Clara", 240.75);
        manager.AddOrder("David", 64.25);

        manager.PrintReport();
    }
}