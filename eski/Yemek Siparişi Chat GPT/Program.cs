using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<FoodItem> menu = new List<FoodItem>()
        {
            new FoodItem("Pizza", 25),
            new FoodItem("Hamburger", 15),
            new FoodItem("Spaghetti", 20),
            new FoodItem("Salad", 10)
        };

        Console.WriteLine("Menu:");
        for (int i = 0; i < menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menu[i].Name} - {menu[i].Price}$");
        }

        Console.WriteLine("Please select an item number to order (press 0 to exit):");

        List<FoodItem> order = new List<FoodItem>();
        int selectedItem;
        while (int.TryParse(Console.ReadLine(), out selectedItem) && selectedItem != 0)
        {
            if (selectedItem > 0 && selectedItem <= menu.Count)
            {
                order.Add(menu[selectedItem - 1]);
                Console.WriteLine($"{menu[selectedItem - 1].Name} added to the order.");
            }
            else
            {
                Console.WriteLine("Invalid item number. Please try again.");
            }
        }

        if (order.Count > 0)
        {
            Console.WriteLine("Order summary:");
            double total = 0;
            foreach (FoodItem item in order)
            {
                Console.WriteLine($"{item.Name} - {item.Price}$");
                total += item.Price;
            }

            Console.WriteLine($"Total: {total}$");
        }
        else
        {
            Console.WriteLine("No items ordered. Exiting...");
        }
    }
}

class FoodItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public FoodItem(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

