using SolidAPI.Interfaces;

namespace SolidAPI.Models;

//Open/Closed principle: Instead of modifying PriceCalculator, the functionality is extended by a new class
// DiscountedPriceCalculator which uses the abstraction IPriceCalculator. We are applying the Dependency Inversion principle
// at the same time.

//Dependency Inversion Principle - Instead of depending on low-level module for
//eg: another service, depend on abstraction - IPriceCalculator
public class DiscountedPriceCalculator : IPriceCalculator
{
    private readonly decimal _discount;
    public DiscountedPriceCalculator(decimal discount)
    {
        _discount = discount;
    }
  
    public decimal CalculatePrice(Product product) => product.Price * _discount;
}