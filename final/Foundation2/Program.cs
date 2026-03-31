using System;

class Program
{
    static void Main(string[] args)
    {
        Product apple = new Product("Apple", "0ATBHS03", 1.09m, 1);
        Product banana = new Product("Banana", "0BTBHD06", 0.39m, 1);
        Product table = new Product("Table", "0TEBJHF8", 99.59m, 1);
        Product phonecharger = new Product("Phone Charger", "PCXENO1", 10.17m, 1);
        Product phone = new Product("Phone", "0PQNDH02", 1089.89m, 1);
        Product hairbrush = new Product("Hairbrush", "0HEBD67", 3.87m, 1);
        Product pen = new Product("Pen", "0PRBD112", 0.24m, 1);
        Product desklamp = new Product("Desk Lamp", "DLRBFY4", 18.24m, 1);
        Product deskfan = new Product("Desk Fan", "DFEBF09", 22.23m, 1);
        Product keyboard = new Product("Keyboard", "0KRBH02", 30.54m, 1);
        Product rr = new Product("https://www.youtube.com/watch?v=dQw4w9WgXcQ", "RANGGYU69", 17566024.48m, 1);


        Address johnAddress = new Address("Rexburg", "Idaho", "USA");
        Customer john = new Customer("John", johnAddress);
        List<Product> johnProducts = new List<Product>();
        johnProducts.Add(apple);
        johnProducts.Add(table);
        Order johnOrder = new Order(john, johnProducts);
        Console.WriteLine(johnOrder.GetPackingLabel());
        Console.WriteLine(johnOrder.GetShippingLabel());
        Console.WriteLine(johnOrder.GetTotalPrice());

        Console.WriteLine("\n\n\n");

        Address andyAddress = new Address("Seattle", "Washington", "USA");
        Customer andy = new Customer("Andy", andyAddress);
        List<Product> andyProducts = new List<Product>();
        andyProducts.Add(phonecharger);
        andyProducts.Add(phone);
        andyProducts.Add(pen);
        andyProducts.Add(desklamp);
        andyProducts.Add(deskfan);
        andyProducts.Add(keyboard);
        andyProducts.Add(banana);
        andyProducts.Add(hairbrush);
        Order andyOrder = new Order(andy, andyProducts);
        Console.WriteLine(andyOrder.GetPackingLabel());
        Console.WriteLine(andyOrder.GetShippingLabel());
        Console.WriteLine(andyOrder.GetTotalPrice());

        Console.WriteLine("\n\n\n");

        Address rickAddress = new Address("The Hexagon", "North Pole", "Jupiter");
        Customer rick = new Customer("Rick", rickAddress);
        List<Product> rickProducts = new List<Product>();
        rickProducts.Add(rr);
        Order rickOrder = new Order(rick, rickProducts);
        Console.WriteLine(rickOrder.GetPackingLabel());
        Console.WriteLine(rickOrder.GetShippingLabel());
        Console.WriteLine(rickOrder.GetTotalPrice());
    }
}