namespace ConcessionnaireFactory
{
    public class CashOrderCreator : OrderCreator
    {
        public override Order CreateOrder() {
            return new CashOrder();
        }
    }
}