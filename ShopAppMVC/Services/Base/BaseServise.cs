using ShopAppMVC.Data;
using ShopAppMVC.Models.Base;
using ShopAppMVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppMVC.Services.Base
{
    public class BaseServise<T>
        where T : Entity
    {
        protected DataContext _dataContext;

        public BaseServise(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Add(T entity)
        {
            entity.CreatedUtc = DateTime.Now;
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();
        }
    }
}
