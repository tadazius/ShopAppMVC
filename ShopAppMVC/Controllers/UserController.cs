using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppMVC.Models;
using ShopAppMVC.Services;

namespace ShopAppMVC.Controllers
{
    public class UserController: Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            var user = _userService.GetAll();
            return View(user);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var user = new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return RedirectToAction("Index");
        }
        
    }
}
