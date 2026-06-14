using System;
using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product(int productId, string productName, int quantity, double price)
    {
        ProductId = productId;
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }
}

class Inventory
{
    private Dictionary<int, Product> products = new Dictionary<int, Product>();
    public void AddProduct(Product product)
    {
        products[product.ProductId] = product;
        Console.WriteLine("Product Added");
    }

    public void UpdateProduct(int id, string name, int quantity, double price)
    {
        if (products.ContainsKey(id))
        {
            products[id].ProductName = name;
            products[id].Quantity = quantity;
            products[id].Price = price;
            Console.WriteLine("Product Updated");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    public void DeleteProduct(int id)
    {
        if (products.Remove(id))
        {
            Console.WriteLine("Product Deleted");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine("\nInventory:");

        foreach (var product in products.Values)
        {
            Console.WriteLine(
                $"ID: {product.ProductId}, " +
                $"Name: {product.ProductName}, " +
                $"Quantity: {product.Quantity}, " +
                $"Price: {product.Price}"
            );
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(new Product(101, "Laptop", 10, 50000));
        inventory.AddProduct(new Product(102, "Mouse", 50, 500));

        inventory.DisplayProducts();

        inventory.UpdateProduct(101, "Gaming Laptop", 8, 65000);

        inventory.DeleteProduct(102);

        inventory.DisplayProducts();
    }
}