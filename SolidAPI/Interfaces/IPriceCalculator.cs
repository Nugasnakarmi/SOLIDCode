namespace SolidAPI.Interfaces;

public interface IPriceCalculator
{
    decimal CalculatePrice(Product product);
}