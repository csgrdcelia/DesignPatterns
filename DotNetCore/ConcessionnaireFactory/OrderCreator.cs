namespace ConcessionnaireFactory
{
    public abstract class OrderCreator
    {
        public void CreateNewOrder() {
            Order order = CreateOrder();
            if(order.Isvalid()) {
                order.Pay();
            }
        }

        public abstract Order CreateOrder();
    }
}