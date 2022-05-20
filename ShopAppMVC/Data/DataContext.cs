using Microsoft.EntityFrameworkCore;
using ShopAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppMVC.Data
{
    public class DataContext: DbContext
    {
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
