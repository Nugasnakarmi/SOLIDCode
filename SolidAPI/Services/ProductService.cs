using SolidAPI.Interfaces;
using System.Collections.Generic;

//Dependency Inversion Principle - Instead of depending on low-level module for
//eg: another service, depend on abstraction
public class ProductService : IProductService 
{
    private readonly IProductRepository _repository;
    private readonly IPriceCalculator _priceCalculator;

    public ProductService(IProductRepository repository, IPriceCalculator priceCalculator)
    {
        //We're doing IoC pattern by inverting control of repository to handler, which is the ProductService, when using Product Service
        //it will have control over which instance of ProductRepository to use.
        _repository = repository;
        _priceCalculator = priceCalculator;
    }

    public List<DiscountedProduct> GetProducts()
    {
        var products = _repository.GetAllProducts();
        foreach (var product in products)
        {
            product.Price = _priceCalculator.CalculatePrice(product);
        }
        return products.ToList();
    }
}
