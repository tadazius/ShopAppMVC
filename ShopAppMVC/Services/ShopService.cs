using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppMVC.Models;

namespace ShopAppMVC.Services
{
    public class ShopService
    {
        public ShopService()
        {
        }
        private List<ShopItem> _shopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Name = "Ice Crem",
                Price = 2,
                StoreName = "Silas",
                ExpiryDate = DateTime.Now,
            },
            new ShopItem()
            {
                Name = "Ice Crem",
                Price = 3,
                StoreName = "Norfa",
                ExpiryDate = DateTime.Now,
            },
            new ShopItem()
            {
                Name = "Ice Crem",
                Price = 2.5M,
                StoreName = "Maxima",
                ExpiryDate = DateTime.Now,
            },
            new ShopItem()
            {
                Name = "Ice Crem",
                Price = 2,
                StoreName = "Iki",
                ExpiryDate = DateTime.Now,
            },
            new ShopItem()
            {
                Name = "Ice Crem",
                Price = 1.56M,
                StoreName = "Rimi",
                ExpiryDate = DateTime.Parse("2022-05-19"),
            }
        };
             

        public List<ShopItem> GetAll()
        {
            return _shopItems;
        }
        public void Add(ShopItem shopItems)
        {
            _shopItems.Add(shopItems);
        }
        public void Delete(string name)
        {
            _shopItems = _shopItems.Where(x => x.Name == name).ToList();
        }
        
    
    }
}
