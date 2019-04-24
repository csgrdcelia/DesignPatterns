namespace Shopping
{
    public class Memento
    {
        IOrderStatus status;

        public Memento(IOrderStatus status) 
        {
            this.status = status;
        }

        public IOrderStatus GetState()
        {
            return status;
        }
    }
}