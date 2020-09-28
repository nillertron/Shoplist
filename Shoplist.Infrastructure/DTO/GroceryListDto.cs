using System;
using System.Collections.Generic;
using System.Text;

namespace Shoplist.Infrastructure.DTO
{
    public class GroceryListDto
    {
        public int Id { get; set; }
        public List<ItemDto> Items { get; set; }
    }
}
