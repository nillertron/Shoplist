using Microsoft.EntityFrameworkCore;
using Shoplist.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shoplist.Database.Command
{
    public class ItemCommand : IItemCommand
    {
        private readonly ShopContext shopContext;
        private readonly DbSet<Item> table;
        public ItemCommand(ShopContext context)
        {
            shopContext = context;
            table = context.Set<Item>();
        }
        public async Task Create(Item item)
        {
            await table.AddAsync(item);
            await shopContext.SaveChangesAsync();
        }
        public async Task Delete(Item item)
        {
            table.Remove(item);
            await shopContext.SaveChangesAsync();

        }
        public async Task Update(Item item)
        {
            table.Update(item);
            await shopContext.SaveChangesAsync();

        }
    }
}
