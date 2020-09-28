using Shoplist.Infrastructure.DTO;
using System.Threading.Tasks;

namespace Shoplist.Infrastructure.GroceryList
{
    public interface IGrocerylistCRUD
    {
        Task Create(GroceryListDto list);
        Task Delete(GroceryListDto list);
        Task<GroceryListDto> GetListFromId(int id);
        Task Update(GroceryListDto list);
    }
}