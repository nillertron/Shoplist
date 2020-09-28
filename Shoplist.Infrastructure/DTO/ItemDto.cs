using System;
using System.Collections.Generic;
using System.Text;

namespace Shoplist.Infrastructure.DTO
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroceryListId { get; set; }
        public ItemDto(int id)
        {
            Id = id;
        }
        public ItemDto()
        {

        }
    }
}
