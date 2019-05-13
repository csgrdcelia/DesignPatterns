namespace Concessionnaire
{
    public class Command
    {
        private ICar car;
        private IPaymentMode paymentMode;
        public Command()
        {

        }

        public void AddCar(ICar car)
        {
            this.car = car;
        }

        public void AddPaymentMode(IPaymentMode paymentMode) 
        {
            this.paymentMode = paymentMode;
        }

        public double Pay()
        {
            return paymentMode.Pay(car.GetPrice());
        }
    }
}