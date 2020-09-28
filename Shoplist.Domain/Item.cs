using System;
using System.Collections.Generic;
using System.Text;

namespace Shoplist.Domain
{
    public class Item
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int GroceryListId { get; set; }
        public GroceryList GroceryList { get; set; }
        public Item()
        {

        }
        public Item(int id)
        {
            this.Id = id;
        }

    }
}
