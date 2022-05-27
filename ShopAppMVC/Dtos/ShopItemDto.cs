using ShopAppMVC.Data;
using ShopAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppMVC.Dtos
{
    public class ShopItemDto
    {
        public ShopItem ShopItem { get; set; }
        public List<UserDto> Users { get; set; }
    }
}
