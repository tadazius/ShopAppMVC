using System;

namespace ShopAppMVC.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StoreName { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
    }
}
