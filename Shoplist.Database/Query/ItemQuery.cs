using Microsoft.EntityFrameworkCore;
using Shoplist.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shoplist.Database.Query
{
    public class ItemQuery : IItemQuery
    {
        private readonly ShopContext shopContext;
        private readonly DbSet<Item> table;
        public ItemQuery(ShopContext context)
        {
            shopContext = context;
            table = context.Set<Item>();
        }
        public async Task<IEnumerable<Item>> GetAll()
        {
            return await table.ToListAsync();
        }
        public async Task<Item> GetFromId(int id)
        {
            return await table.FindAsync(id);
        }
    }
}
