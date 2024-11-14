//Base class Product with member Price and virtual function GetPrice()
public class Product
{
    public decimal Price {  get; set; }
    public virtual decimal GetPrice() => Price;
}

