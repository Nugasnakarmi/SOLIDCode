using SolidAPI.Interfaces;

namespace SolidAPI.Repositories;

//Getting all products is delegated to the ProductRepository and isn't done by the Product Class.
public class ProductRepository: IProductRepository
{
    public IEnumerable<DiscountedProduct> GetAllProducts()
    { // Implementation to retrieve products from the database
        DiscountedProduct[] products = new DiscountedProduct[1];
        products[0] = new DiscountedProduct()
        {
            Id = 1,
            Name = "TestProduct",
            Price = 4,
            discount = 2
        };
        return products;
    }
}