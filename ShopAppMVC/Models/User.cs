using ShopAppMVC.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppMVC.Models
{
    public class User : NamedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ShopItem> ShopItems { get; set; }
    }
}
