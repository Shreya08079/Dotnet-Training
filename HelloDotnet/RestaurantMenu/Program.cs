using System;
using System.Collections.Generic;
using System.Linq;

public class MenuItem
{
    public string? ItemName { get; set; }
    public string? Category { get; set; }   
    public double Price { get; set; }
    public bool IsVegetarian { get; set; }
}

public class MenuManager
{
    private List<MenuItem> menuItems = new List<MenuItem>();

    public void AddMenuItem(string name, string category, double price, bool isVeg)
    {
        if (price <= 0)
        {
            Console.WriteLine("Price must be greater than 0");
            return;
        }

        menuItems.Add(new MenuItem
        {
            ItemName = name,
            Category = category,
            Price = price,
            IsVegetarian = isVeg
        });
    }

    public Dictionary<string, List<MenuItem>> GroupItemsByCategory()
    {
        Dictionary<string, List<MenuItem>> result =
            new Dictionary<string, List<MenuItem>>();

        foreach (var item in menuItems)
        {
            if (!result.ContainsKey(item.Category))
            {
                result[item.Category] = new List<MenuItem>();
            }

            result[item.Category].Add(item);
        }

        return result;
    }

    public List<MenuItem> GetVegetarianItems()
    {
        return menuItems.Where(i => i.IsVegetarian).ToList();
    }

    public double CalculateAveragePriceByCategory(string category)
    {
        var items = menuItems
            .Where(i => i.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (items.Count == 0)
            return 0;

        return items.Average(i => i.Price);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MenuManager manager = new MenuManager();

        // Add menu items
        manager.AddMenuItem("Spring Rolls", "Appetizer", 150, true);
        manager.AddMenuItem("Chicken Wings", "Appetizer", 220, false);
        manager.AddMenuItem("Paneer Butter Masala", "Main Course", 320, true);
        manager.AddMenuItem("Chicken Biryani", "Main Course", 380, false);
        manager.AddMenuItem("Gulab Jamun", "Dessert", 120, true);
        manager.AddMenuItem("Ice Cream", "Dessert", 100, true);

        // Display menu by category
        Console.WriteLine("MENU BY CATEGORY\n");
        var grouped = manager.GroupItemsByCategory();

        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var item in group.Value)
            {
                Console.WriteLine($"  {item.ItemName} - ₹{item.Price}");
            }
            Console.WriteLine();
        }

        // Vegetarian menu
        Console.WriteLine("VEGETARIAN MENU\n");
        foreach (var item in manager.GetVegetarianItems())
        {
            Console.WriteLine($"{item.ItemName} ({item.Category}) - ₹{item.Price}");
        }

        // Average prices
        Console.WriteLine("\nAVERAGE PRICE BY CATEGORY");
        Console.WriteLine("Appetizer: ₹" + manager.CalculateAveragePriceByCategory("Appetizer"));
        Console.WriteLine("Main Course: ₹" + manager.CalculateAveragePriceByCategory("Main Course"));
        Console.WriteLine("Dessert: ₹" + manager.CalculateAveragePriceByCategory("Dessert"));
    }
}
