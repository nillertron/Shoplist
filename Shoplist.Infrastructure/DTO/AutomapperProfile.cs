using Shoplist.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoplist.Infrastructure.DTO
{
   public class AutomapperProfile:AutoMapper.Profile
    {
        public AutomapperProfile()
        {
            
            CreateMap<Domain.GroceryList, GroceryListDto>().ReverseMap();
            CreateMap<Domain.Item, ItemDto>().ReverseMap();

        }
    }
}
