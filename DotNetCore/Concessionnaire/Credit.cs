namespace Concessionnaire
{
    public class Credit : IPaymentMode
    {
        ICreditType creditType;
        int tax = 10;
        public Credit(ICreditType creditType) 
        {
            this.creditType = creditType;
        }

        public double Pay(double amount) 
        {
            return amount + creditType.GetNumberOfPayments() * tax;
        }
    }
}