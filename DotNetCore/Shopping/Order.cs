using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Order : ICloneableOrder
    {
        private IOrderStatus status;
        private List<Item> items;
        public List<Item> Items { get => items; }

        public Order() 
        {
            items = new List<Item>();
            status = new InProgressStatus();
        }

        public Order(IOrderStatus status, List<Item> items)
        {
            this.status = status;
            this.items = items;
        }

        public void SetMemento(Memento memento)
        {
            status = memento.GetState();
        }

        public Memento CreateMemento() 
        {
            return new Memento(status);
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

        public ICloneableOrder Clone()
        {
            Order order = (Order)this.MemberwiseClone();
            order.status = new InProgressStatus();
            return (ICloneableOrder)order;
        }
    }
}
