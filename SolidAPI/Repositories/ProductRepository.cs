using SolidAPI.Interfaces;

namespace SolidAPI.Repositories;

//Getting all products is delegated to the ProductRepository and isn't done by the Product Class.
public class ProductRepository: IProductRepository
{
    public IEnumerable<Product> GetAllProducts()
    { // Implementation to retrieve products from the database
        Product[] products = new Product[1];
        products[0] = new Product()
        {
            Id = 1,
            Name = "TestProduct",
            Price = 4
        };
        return products;
    }
}