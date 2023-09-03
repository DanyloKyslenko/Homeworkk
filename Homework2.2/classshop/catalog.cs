using System;
using System.Collections.Generic;

public class Catalog
{
    private List<Product> products = new List<Product>
    {
        new Product("Almond honey cupcake", 10),
        new Product("Chocolate cupcake", 10),
        new Product("Strawberry cupcake", 10),
        new Product("Raspberry cupcake", 10),
        new Product("Lemon cupcake", 10),
        new Product("Almond honey cake", 10),
        new Product("Chocolate cake", 10),
        new Product("Strawberry cake", 10),
        new Product("Raspberry cake", 10),
        new Product("Lemon cake", 10)
    };

    public void ShowCatalog()
    {
        Console.WriteLine("Catalog:");
        foreach (var product in products)
        {
            Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}");
        }
    }

    public void AddToCatalog(string name, int quantity)
    {
        products.Add(new Product(name, quantity));
        Console.WriteLine($"Added {quantity} {name} to the catalog.");
    }

    public Product GetProductByName(string name)
    {
        return products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
