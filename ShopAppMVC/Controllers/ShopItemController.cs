using Microsoft.AspNetCore.Mvc;
using ShopAppMVC.Dtos;
using ShopAppMVC.Models;
using ShopAppMVC.Services;
using System.Collections.Generic;

namespace ShopAppMVC.Controllers
{
    public class ShopItemController : Controller
    {
        private ShopItemService _shopItemService;
        private UserService _userService;
        public ShopItemController(ShopItemService shopService, UserService userService)
        {
            _shopItemService = shopService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            var shops = _shopItemService.GetAll();
            return View(shops);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ShopItemDto shopItem = new ShopItemDto();
            shopItem.Users = _userService.GetAll();
            return View(shopItem);
        }
        [HttpPost]
        public IActionResult Add(ShopItemDto createShopItemDto)
        {
            
            _shopItemService.Add(createShopItemDto);

            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            _shopItemService.Delete(id);
            return RedirectToAction("Index");
        }

        /*[HttpGet]*/
        public IActionResult Update(int id)
            {
                var item = _shopItemService.Get(id);
                return View(item);
            }
        [HttpPost]
        public IActionResult Update(ShopItem shopItem)
        {

            _shopItemService.Update(shopItem);
            return RedirectToAction("Index");
        }
        public void Get(int id)
        {
            var shopItem = _shopItemService.FirstOrDefault()
        }
    }
}
