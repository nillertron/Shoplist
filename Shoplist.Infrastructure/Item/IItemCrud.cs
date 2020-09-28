using Shoplist.Infrastructure.DTO;
using System.Threading.Tasks;

namespace Shoplist.Infrastructure.Item
{
    public interface IItemCrud
    {
        Task Create(ItemDto item);
        Task Delete(ItemDto item);
        Task<ItemDto> GetItemFromId(int id);
        Task Update(ItemDto item);
    }
}