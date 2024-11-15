//Liskov Substitution Principle
//Base classes should be substitutable by base classes
//Base class Product is substituted by derived class DiscountedProduct
public class DiscountedProduct : Product
{
    private readonly decimal _discount;

    public DiscountedProduct(decimal discount)
    {
        {
            _discount = discount;
        }
    }

public override decimal GetPrice() => base.GetPrice() * _discount;
}