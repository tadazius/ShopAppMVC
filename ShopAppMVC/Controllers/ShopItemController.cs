using Microsoft.AspNetCore.Mvc;
using ShopAppMVC.Services;

namespace ShopAppMVC.Controllers
{
    public class ShopItemController : Controller
    {
        private ShopService _shopService;
        public ShopItemController(ShopService shopService)
        {
            _shopService = shopService;
        }
        public IActionResult Index()
        {
            var shop = _shopService.GetAll();
            return View(shop);
        }
    }
}
