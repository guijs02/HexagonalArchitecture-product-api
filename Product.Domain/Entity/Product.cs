using System;

namespace Product.Domain.Entity;

public sealed class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    // Constructor
    public Product(Guid id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public void Validate(){
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new ArgumentException("Product name cannot be empty.");
        }
        if (Price <= 0)
        {
            throw new ArgumentException("Product price must be greater than zero.");
        }
        if (Id == Guid.Empty)
        {
            throw new ArgumentException("Product ID cannot be empty.");
        }
    }
    // Method to display product details
    public override string ToString()
    {
        return $"Product ID: {Id}, Name: {Name}, Price: {Price:C}";
    }
}