using Microsoft.EntityFrameworkCore;
using Shoplist.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shoplist.Database.Command
{
    public class GrocerylistCommand : IGrocerylistCommand
    {
        private readonly ShopContext shopContext;
        private readonly DbSet<GroceryList> table;
        public GrocerylistCommand(ShopContext context)
        {
            shopContext = context;
            table = context.Set<GroceryList>();
        }
        public async Task Create(GroceryList item)
        {
            await table.AddAsync(item);
            await shopContext.SaveChangesAsync();
        }
        public async Task Delete(GroceryList item)
        {
            table.Remove(item);
            await shopContext.SaveChangesAsync();

        }
        public async Task Update(GroceryList item)
        {
            table.Update(item);
            await shopContext.SaveChangesAsync();

        }
    }
}
