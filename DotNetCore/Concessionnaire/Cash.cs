namespace Concessionnaire
{
    public class Cash : IPaymentMode
    {
        public double Pay(double amount) 
        {
            return amount;
        }
    }
}