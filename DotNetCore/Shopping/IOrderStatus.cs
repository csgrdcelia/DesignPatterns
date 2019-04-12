using System.Collections.Generic;
namespace Shopping
{
    public interface IOrderStatus
    {
         IOrderStatus NextStatus { get; set; }
         List<Item> AddItem(List<Item> items, Item item);
         List<Item> RemoveItem(List<Item> items, Item item);
    }
}