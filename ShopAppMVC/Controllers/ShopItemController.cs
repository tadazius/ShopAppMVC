using Microsoft.AspNetCore.Mvc;
using ShopAppMVC.Dtos;
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
        public IActionResult Add()
        {
            var shopItem = new CreateShopItemDto();
            return View(shopItem);
        }
        [HttpPost]
        public IActionResult Add(CreateShopItemDto createShop)
        {
            _shopService.Add(createShop.ShopItem);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string name)
        {
            _shopService.Delete(name);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult Update(int Id)
        //{
            
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        public IActionResult Update(int Id)
        {
           
            _shopService.Update(Id);
           // _shopService.Add(item);
            return RedirectToAction("Index");
        }
    }
}
