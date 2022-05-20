using ShopAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppMVC.Dtos
{
    public class CreateShopItemDto
    {
        public ShopItem ShopItem { get; set; }
        public List<User> Users { get; set; }
    }
}
