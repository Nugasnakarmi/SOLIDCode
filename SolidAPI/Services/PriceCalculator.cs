namespace SolidAPI.Services
{
    public class PriceCalculator
    {
        public decimal CalculatePrice(Product product) => product.Price;
        public decimal CalculateDiscountedPrice(DiscountedProduct product) => product.GetPrice();
    }
}
