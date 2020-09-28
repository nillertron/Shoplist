using Shoplist.Database.Command;
using Shoplist.Database.Query;
using System.Threading.Tasks;
using System.Linq;
using Shoplist.Infrastructure.DTO;
using AutoMapper;

namespace Shoplist.Infrastructure.GroceryList
{
    public class GrocerylistCRUD : IGrocerylistCRUD
    {
        private readonly IGrocerylistQuery grocerylistQuery;
        private readonly IGrocerylistCommand grocerylistCommand;
        private readonly IMapper mapper;
        public GrocerylistCRUD(IGrocerylistQuery grocerylistQuery, IGrocerylistCommand grocerylistCommand, IMapper mapper)
        {
            this.grocerylistQuery = grocerylistQuery;
            this.grocerylistCommand = grocerylistCommand;
            this.mapper = mapper;
        }
        public async Task<GroceryListDto> GetListFromId(int id)
        {
            var obj = mapper.Map<GroceryListDto>(await grocerylistQuery.GetFromId(id));


            return obj;
        }
        public async Task Create(GroceryListDto list)
        {
            await grocerylistCommand.Create(mapper.Map<Domain.GroceryList>(list));
        }
        public async Task Delete(GroceryListDto list)
        {
            await grocerylistCommand.Delete(mapper.Map<Domain.GroceryList>(list));
        }
        public async Task Update(GroceryListDto list)
        {
            await grocerylistCommand.Update(mapper.Map<Domain.GroceryList>(list));
        }
    }
}
