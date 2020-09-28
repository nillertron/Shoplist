using Shoplist.Domain;
using System.Threading.Tasks;

namespace Shoplist.Database.Command
{
    public interface IGrocerylistCommand
    {
        Task Create(GroceryList item);
        Task Delete(GroceryList item);
        Task Update(GroceryList item);
    }
}