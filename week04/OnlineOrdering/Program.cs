using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product product1 = new Product("milk", 0, 2.99, 1);
        Product product2 = new Product("eggs", 1, 0.75, 12);
        Product product3 = new Product("ground beef", 2, 10.59, 2);
        Product product4 = new Product("peanut butter", 3, 4.95, 1);
        Product product5 = new Product("apples", 4, 1.60, 3);
        List<Product> cart1 = new List<Product>();
        List<Product> cart2 = new List<Product>();
        cart1.AddRange(product1, product2, product3);
        cart2.AddRange(product4, product5, product2);
        Address addy1 = new Address("3675 S 900 E", "Millcreek", "Utah", "USA");
        Address addy2 = new Address("Adolfo Lopez Mateos 98A", "Aguascalientes", "Aguascalients", "Mexico");
        Customer customer1 = new Customer("John", addy1);
        Customer customer2 = new Customer("Alonso", addy2);

        Order order1 = new Order(cart1, customer1);
        Order order2 = new Order(cart2, customer2);

        Console.WriteLine(order1.returnShippingLabel());
        Console.WriteLine(order1.returnPackingLabel());
        Console.WriteLine($"\nTotal: ${order1.calcTotal()}");
        Console.WriteLine(order2.returnShippingLabel());
        Console.WriteLine(order2.returnPackingLabel());
        Console.WriteLine($"\nTotal: ${order2.calcTotal()}");
    }
}