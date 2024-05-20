using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Web.Controllers;

[ApiController]
[ApiVersion("1")]
[Route("api/v1/[controller]")]
public class CatalogController : ControllerBase
{
    private static readonly List<CatalogItem> Catalog =
    [
        new CatalogItem
        {
            Id = 1,
            Title = "T-Shirt",
            Price = 29.99M
        },
        new CatalogItem
        {
            Id = 2,
            Title = "Scarf",
            Price = 12.5M
        },
        new CatalogItem
        {
            Id = 3,
            Title = "Gown",
            Price = 45.2M
        }
    ];

    private readonly ILogger<CatalogController> _logger;

    public CatalogController(ILogger<CatalogController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("homepage")]
    public IEnumerable<CatalogItem> Homepage()
    {
        return Catalog;
    }

    [HttpGet]
    [Route("product/{productId}")]
    public CatalogItem GetProduct(int productId)
    {
        var product = Catalog.FirstOrDefault(x => x.Id == productId);

        return product;
    }

    public class CatalogItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}