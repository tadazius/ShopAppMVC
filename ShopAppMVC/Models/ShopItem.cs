using System;

namespace ShopAppMVC.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string StoreName { get; set; }

        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
