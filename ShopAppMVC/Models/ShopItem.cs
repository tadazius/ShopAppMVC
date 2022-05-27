using ShopAppMVC.Models.Base;
using System;

namespace ShopAppMVC.Models
{
    public class ShopItem : NamedEntity
    {
        
        public string StoreName { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpireDate { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
    }
}
