using System.Xml.Linq;
using System.Collections.Generic;
namespace Shopping
{
    public class InProgressStatus : IOrderStatus
    {
        public IOrderStatus NextStatus { get; set; }

        public InProgressStatus()
        {
            NextStatus = new ValidatedStatus();
        }
        public List<Item> AddItem(List<Item> items, Item item) 
        {
            items.Add(item);
            return items;
        }
        public List<Item> RemoveItem(List<Item> items, Item item)
        {
            items.Remove(item);
            return items;
        }
    }
}