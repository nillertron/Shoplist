using Shoplist.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shoplist.Database.Query
{
    public interface IItemQuery
    {
        Task<IEnumerable<Item>> GetAll();
        Task<Item> GetFromId(int id);
    }
}