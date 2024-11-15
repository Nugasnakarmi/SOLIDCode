
using Microsoft.AspNetCore.Mvc;
using SolidAPI.Interfaces;
namespace SolidAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductController: ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService) {
        _productService = productService;
    }

    //get Products
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = _productService.GetProducts();

        return Ok(products);

    }
}
