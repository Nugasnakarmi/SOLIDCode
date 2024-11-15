//Liskov Substitution Principle
//Base class Product is substituted by derived class DiscountedProduct everywhere in the API
//and it doesn't affect the correctness of the program, this maintains inheritance hierarchy correctness.
public class DiscountedProduct : Product
{
    public decimal discount;

public override decimal GetPrice() => base.GetPrice() * discount;
}