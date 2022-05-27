using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppMVC.Models.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
