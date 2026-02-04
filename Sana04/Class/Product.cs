using Sana04.Class;

public class Product
{
    protected string Name;
    protected float Price;
    protected Currency Cost;
    protected int Quantity;
    protected string Producer;
    protected float Weight;

    public Product() { }

    public Product(string name, float price, Currency cost, int quantity, string producer, float weight)
    {
        Name = name;
        SetPrice(price);
        Cost = cost;
        SetQuantity(quantity);
        Producer = producer;
        SetWeight(weight);
    }

    public Product(string name, float price, Currency cost, int quantity, string producer)
    {
        Name = name;
        SetPrice(price);
        Cost = cost;
        SetQuantity(quantity);
        Producer = producer;
        SetWeight(170);
    }

    public Product(Product other)
    {
        Name = other.Name;
        Price = other.Price;
        Cost = other.Cost;
        Quantity = other.Quantity;
        Producer = other.Producer;
        Weight = other.Weight;
    }

    public void SetPrice(float price)
    {
        if (price <= 0)
            throw new Exception("Wrong price.");
        Price = price;
    }

    public void SetQuantity(int quantity)
    {
        if (quantity < 0)
            throw new Exception("Wrong quantity.");
        Quantity = quantity;
    }

    public void SetWeight(float weight)
    {
        if (weight <= 0)
            throw new Exception("Wrong weight.");
        Weight = weight;
    }

    public float GetPriceInUAH()
    {
        return Price * Cost.GetExRate();
    }

    public float GetTotalPriceInUAH()
    {
        return GetPriceInUAH() * Quantity;
    }

    public float GetTotalWeight()
    {
        return Weight * Quantity;
    }
}