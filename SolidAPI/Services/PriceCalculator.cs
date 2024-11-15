using SolidAPI.Interfaces;

namespace SolidAPI.Services
{
    public class PriceCalculator: IPriceCalculator
    {
        public decimal CalculatePrice(Product product) => product.Price;
    }
}
