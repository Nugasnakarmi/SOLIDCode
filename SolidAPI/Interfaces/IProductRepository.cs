namespace SolidAPI.Interfaces;
    public interface IProductRepository
    {
        public IEnumerable<DiscountedProduct> GetAllProducts();
    }

