using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Basket.Api.Web.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v1/[controller]")]
    public class BasketController : ControllerBase
    {
        public static readonly List<BasketItem> Basket = [
            new BasketItem {
                Id = 1,
                UserId = 1,
                ProductId = 2,
                Title = "Scarf",
            },
            new BasketItem {
                Id = 2,
                UserId = 1,
                ProductId = 1,
                Title = "T-Shirt"
            },
            new BasketItem {
                Id = 3,
                UserId = 2,
                ProductId = 1,
                Title = "T-Shirt"
            }
        ];

        public BasketController()
        { }

        [HttpGet]
        [Route("user/{userId}")]
        public IEnumerable<BasketItem> GetUserProducts(int userId)
        {
            return Basket.Where(x => x.UserId == userId).ToList();
        }

        public class BasketItem
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public int ProductId { get; set; }
            public string Title { get; set; }
        }
    }
}