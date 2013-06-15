using System;

public class Product:IComparable<Product>
{
    private string name;
    private int price;

    public Product(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
    
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public int CompareTo(Product other)
    {
        return this.price.CompareTo(other.price);
    }
}