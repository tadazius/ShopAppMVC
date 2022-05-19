using Microsoft.AspNetCore.Mvc;
using ShopAppMVC.Models;
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
        [HttpGet]
        public IActionResult Add ()
        {
            ShopItem shopItem = new ShopItem();
            return View(shopItem);
        }
        [HttpPost]
        public IActionResult Add(ShopItem shop)
        {
            _shopService.Add(shop);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string name)
        {
            _shopService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
