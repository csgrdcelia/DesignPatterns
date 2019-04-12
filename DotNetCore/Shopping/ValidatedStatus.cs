using System.Collections.Generic;
namespace Shopping
{
    public class ValidatedStatus : IOrderStatus
    {
        public IOrderStatus NextStatus { get; set; }

        public ValidatedStatus()
        {
            NextStatus = new DeliveredStatus();
        }

        public List<Item> AddItem(List<Item> items, Item item) 
        {
            throw new System.NotSupportedException();
        }
        public List<Item> RemoveItem(List<Item> items, Item item)
        {
            items.Remove(item);
            return items;
        }
    }
}