namespace Shopping
{
    public class Client
    {
        public ICloneableOrder CreateOrderFromAnother(Order order) {
            return order.Clone();
        }
    }
}