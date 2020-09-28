using Shoplist.Domain;
using System.Threading.Tasks;

namespace Shoplist.Database.Command
{
    public interface IItemCommand
    {
        Task Create(Item item);
        Task Delete(Item item);
        Task Update(Item item);
    }
}