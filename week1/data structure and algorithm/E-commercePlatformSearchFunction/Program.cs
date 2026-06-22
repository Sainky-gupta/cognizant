using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    static Product? LinearSearch(Product[] products, int id)
    {
        foreach (Product p in products)
        {
            if (p.ProductId == id)
                return p;
        }
        return null;
    }

    static Product? BinarySearch(Product[] products, int id)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == id)
                return products[mid];
            else if (products[mid].ProductId < id)
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
            new Product(101, "Headphones", "Electronics"),
            new Product(102, "Backpack", "Accessories"),
            new Product(103, "Notebook", "Stationery"),
            new Product(104, "Water Bottle", "Utility")
        };

        Console.Write("Enter Product ID to search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        Product? linearResult = LinearSearch(products, searchId);

        Console.WriteLine("\nLinear Search:");
        if (linearResult != null)
        {
            Console.WriteLine($"ID: {linearResult.ProductId}, Name: {linearResult.ProductName}, Category: {linearResult.Category}");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }

        Product? binaryResult = BinarySearch(products, searchId);

        Console.WriteLine("\nBinary Search:");
        if (binaryResult != null)
        {
            Console.WriteLine($"ID: {binaryResult.ProductId}, Name: {binaryResult.ProductName}, Category: {binaryResult.Category}");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }
}