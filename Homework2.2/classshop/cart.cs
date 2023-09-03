using System;
using System.Collections.Generic;
using System.Linq;

public class Cart
{
    private List<Product> cartItems = new List<Product>();

    public void AddToCart(Product product, Catalog catalog)
    {
        var catalogProduct = catalog.GetProductByName(product.Name);
        if (catalogProduct != null && catalogProduct.Quantity >= product.Quantity)
        {
            cartItems.Add(product);
            catalogProduct.Quantity -= product.Quantity;
            Console.WriteLine($"Added {product.Quantity} {product.Name} to the cart.");
        }
        else
        {
            Console.WriteLine("Product not found in the catalog or insufficient quantity.");
        }
    }

    public void ShowCart()
    {
        Console.WriteLine("Cart Contents:");
        foreach (var product in cartItems)
        {
            Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}");
        }
    }

    public void RemoveFromCart(Product product, Catalog catalog)
    {
        var cartProduct = cartItems.FirstOrDefault(p => p.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase));
        if (cartProduct != null && cartProduct.Quantity >= product.Quantity)
        {
            cartItems.Remove(cartProduct);
            var catalogProduct = catalog.GetProductByName(product.Name);
            catalogProduct.Quantity += product.Quantity;
            Console.WriteLine($"Removed {product.Quantity} {product.Name} from the cart.");
        }
        else
        {
            Console.WriteLine("Product not found in the cart or insufficient quantity.");
        }
    }

    public void Buy()
    {
        Console.WriteLine("Thanks for buy:");
        foreach (var product in cartItems)
        {
            Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}");
        }
        cartItems.Clear();
    }
}
