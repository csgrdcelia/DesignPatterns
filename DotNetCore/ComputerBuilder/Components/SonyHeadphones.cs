namespace ComputerBuilderNs
{
    public class SonyHeadphones : IHeadphone
    {
        private double _price = 20;

        public double GetPrice() {
            return _price;
        }
    }
}