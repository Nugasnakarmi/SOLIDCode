namespace SolidAPI.Interfaces;

public interface IPriceCalculator
{
    decimal CalculatePrice(DiscountedProduct product);
}