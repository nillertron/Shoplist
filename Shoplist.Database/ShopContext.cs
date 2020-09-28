using Microsoft.EntityFrameworkCore;
using Shoplist.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoplist.Database
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions opt):base(opt)
        {

        }
        public DbSet<Item> SL_Items { get; set; }
        public DbSet<GroceryList> SL_GroceryLists { get; set; }
    }
}
