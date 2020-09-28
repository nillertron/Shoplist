using AutoMapper;
using Shoplist.Database.Command;
using Shoplist.Database.Query;
using Shoplist.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shoplist.Infrastructure.Item
{
    public class ItemCrud :  IItemCrud
    {
        private readonly IItemQuery itemQuery;
        private readonly IItemCommand itemCommand;
        private readonly IMapper mapper;
        public ItemCrud(IItemQuery itemQuery, IItemCommand itemCommand, IMapper mapper)
        {
            this.itemQuery = itemQuery;
            this.itemCommand = itemCommand;
            this.mapper = mapper;
        }
        public async Task<ItemDto> GetItemFromId(int id)
        {
            return mapper.Map<ItemDto>(await itemQuery.GetFromId(id));
        }
        public async Task Create(ItemDto item)
        {
            var itemToCreate = mapper.Map<Domain.Item>(item);
            await itemCommand.Create(itemToCreate);
            item.Id = itemToCreate.Id;
        }
        public async Task Delete(ItemDto item)
        {
            await itemCommand.Delete(mapper.Map<Domain.Item>(item));
        }
        public async Task Update(ItemDto item)
        {
            await itemCommand.Update(mapper.Map<Domain.Item>(item));
        }
    }
}
