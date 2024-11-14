//Base class Product with member Price and virtual function GetPrice()
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public decimal Price
    {
        get; set;
    }

    public virtual decimal GetPrice() => Price;
}