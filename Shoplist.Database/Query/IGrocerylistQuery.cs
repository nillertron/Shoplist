using Shoplist.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shoplist.Database.Query
{
    public interface IGrocerylistQuery
    {
        Task<IEnumerable<GroceryList>> GetAll();
        Task<GroceryList> GetFromId(int id);
    }
}