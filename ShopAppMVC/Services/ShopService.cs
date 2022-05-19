using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppMVC.Data;
using ShopAppMVC.Models;

namespace ShopAppMVC.Services
{
    public class ShopService
    {
        private DataContext _dataContext;
        public ShopService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<ShopItem> GetAll()
        {
            return _dataContext.ShopItems.ToList();
        }
        public void Add(ShopItem shopItems)
        {
            _dataContext.ShopItems.Add(shopItems);
            _dataContext.SaveChanges();
        }
        public void Delete(string name)
        {
            var shopItem = _dataContext.ShopItems.FirstOrDefault(x => x.Name == name);
            if (shopItem != null)
            {
                _dataContext.ShopItems.Remove(shopItem);
            }
            _dataContext.SaveChanges();

        }
        public void Update(int id)
        {
            var item = _dataContext.ShopItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _dataContext.ShopItems.Remove(item);
            }
            item = _dataContext.ShopItems.FirstOrDefault(x => x.Id == id);

        }

        public void Get(int id)
        {
         
            //return _dataContext.ShopItems.;
        }
    }
}
