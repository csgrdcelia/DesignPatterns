namespace ConcessionnaireFactory
{
    public class CreditOrderCreator : OrderCreator
    {
        public override Order CreateOrder() {
            return new CreditOrder();
        }
    }
}