using System.Collections.Generic;
using NovintItemEditor.Utils;

namespace NovintItemEditor.Structure.Items
{
    public class ItemCollection
    {
        public List<Item> Items { get; private set; } = new List<Item>();
        public int[] LockedItems = {0};

        public void AddItem(Item item)
        {
            Items.Add(item);
            RebuildItems();
        }
        public void RemoveItem(int index)
        {
            Items.RemoveAll(item => item.ItemId == index);
            RebuildItems();
        }

        private void RebuildItems()
        {
            var items = new List<Item>();
            var i = 0;
            foreach (var item in Items)
            {
                var newItem = new Item()
                {
                    ItemId = i,
                    Name = item.Name,
                    IconFilename = item.IconFilename,
                    BypassesRequirements = item.BypassesRequirements,
                    IsUnique = item.IsUnique
                };
                items.Add(newItem);
                i++;
            }

            Items = items;
        }
    }
}
