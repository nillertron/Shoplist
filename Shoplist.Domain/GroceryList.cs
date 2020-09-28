using System;
using System.Collections.Generic;
using System.Text;

namespace Shoplist.Domain
{
    public class GroceryList
    {
        public int Id { get; private set; }
        private readonly List<Item> _items;
        public IEnumerable<Item> Items { get => _items; }

        public GroceryList()
        {
            _items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }
        public GroceryList(int id)
        {
            _items = new List<Item>();
            this.Id = id;
        }
    }
}
