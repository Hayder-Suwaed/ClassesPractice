using System;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Haider");
            var order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
