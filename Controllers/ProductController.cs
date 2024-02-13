using Microsoft.AspNetCore.Mvc;

namespace demoproductsapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    Product[] products = new Product[]
    {
        new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
        new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
        new Product { Id = 3, Name = "Drum", Category = "Toys", Price = 3.75M },
        new Product { Id = 4, Name = "Chair", Category = "Furniture", Price = 3.75M },
        new Product { Id = 5, Name = "XboX", Category = "Toys", Price = 3.75M },
        new Product { Id = 6, Name = "Hammer", Category = "Hardware", Price = 16.99M },
        new Product { Id = 7, Name = "Nails", Category = "Hardware", Price = 3.75M }
    };

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProductDetails")]
    public IEnumerable<Product> GetProductsDetails()
    {
        //return list of products
        return products;

    }
}
