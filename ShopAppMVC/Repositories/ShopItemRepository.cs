using ShopAppMVC.Data;
using ShopAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppMVC.Repositories
{
    public class ShopItemRepository : RepositoryBase<ShopItem>
    {
        public ShopItemRepository(DataContext dataContext)
        { }
    }
}
