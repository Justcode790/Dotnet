using System;
class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId=id;
        ProductName=name;
        Category=category;
    }
}

class Program
{
    static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }

        return null;
    }

    static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == targetId)
                return products[mid];

            if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Mouse","Electronics"),
            new Product(103,"Book","Education"),
            new Product(104,"Keyboard","Electronics"),
            new Product(105,"Tablet","Electronics")
        };

        Product linearResult = LinearSearch(products, 104);

        Console.Write("Linear Search:");
        if (linearResult != null)
            Console.WriteLine(linearResult.ProductName);
        else Console.WriteLine("product is not found ");

        Product binaryResult = BinarySearch(products, 104);
        Console.Write("Binary Search:");

        if (binaryResult != null)
            Console.WriteLine(binaryResult.ProductName);
        else Console.WriteLine("product is not found");
    }   
}