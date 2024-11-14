using System.Collections.Generic;

//Dependency Inversion Principle - Instead of depending on low-level module for
//eg: another service, depend on abstraction
public class ProductService : IProductService 
{
    private readonly IProductRepository _repository;
    private readonly IPriceCalculator _priceCalculator;

    public ProductService(IProductRepository repository, IPriceCalculator priceCalculator)
    {
        _repository = repository;
        _priceCalculator = priceCalculator;
    }

    public IEnumerable<Product> GetProducts()
    {
        var products = _repository.GetAllProducts();
        foreach (var product in products)
        {
            product.Price = _priceCalculator.CalculatePrice(product);
        }
        return products;
    }
}
