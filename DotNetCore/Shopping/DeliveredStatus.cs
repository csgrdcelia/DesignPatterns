using System.Collections.Generic;
namespace Shopping
{
    public class DeliveredStatus : IOrderStatus
    {
        public IOrderStatus NextStatus { get; set; }
        public List<Item> AddItem(List<Item> items, Item item) 
        {
            throw new System.NotSupportedException();
        }
        public List<Item> RemoveItem(List<Item> items, Item item)
        {
            throw new System.NotSupportedException();
        }
    }
}