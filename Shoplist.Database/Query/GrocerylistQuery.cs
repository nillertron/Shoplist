using Microsoft.EntityFrameworkCore;
using Shoplist.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Shoplist.Database.Query
{
    public class GrocerylistQuery : IGrocerylistQuery
    {
        private readonly ShopContext shopContext;
        private readonly DbSet<GroceryList> table;
        public GrocerylistQuery(ShopContext context)
        {
            shopContext = context;
            table = context.Set<GroceryList>();
        }
        public async Task<IEnumerable<GroceryList>> GetAll()
        {
            return await table.ToListAsync();
        }
        public async Task<GroceryList> GetFromId(int id)
        {
            return await table.Where(x=>x.Id == id).Include(x=>x.Items).FirstOrDefaultAsync();
        }
    }
}
