using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppMVC.Data;
using ShopAppMVC.Models;
using ShopAppMVC.Dtos;
using ShopAppMVC.Repositories;

namespace ShopAppMVC.Services
{
    public class ShopItemService
    {
        private ShopItemRepository _shopItemRepository;

        public ShopItemService(ShopItemRepository shopItemRepository)
        {
            _shopItemRepository = shopItemRepository;
        }

        public List<ShopItem> GetAll()
        {
            return _shopItemRepository.GetAll();

        }

        public void Add(ShopItemDto shopItemDto)
        {
            ShopItem shopItem = new ShopItem
            {
                Name = shopItemDto.ShopItem.Name,
                StoreName = shopItemDto.ShopItem.StoreName,
            };
            _shopItemRepository.Add(shopItem);
        }

        public void Delete(int id)
        {
            _shopItemRepository.Delete(id);
        }

        public void Update(int id)
        { }
       
    }
}
