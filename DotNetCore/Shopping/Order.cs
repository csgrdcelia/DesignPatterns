using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Order
    {
        private IOrderStatus status;
        private List<Item> items;
        public List<Item> Items { get => items; }

        public Order() 
        {
            items = new List<Item>();
            status = new InProgressStatus();
        }
        public void AddItem(Item item)
        {
            status.AddItem(items, item);
        }
        public void RemoveItem(Item item)
        {
            status.RemoveItem(items, item);
        }

        public void NextStatus()
        {
            status = status.NextStatus;
        }
    }
}
