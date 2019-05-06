namespace ComputerBuilderNs
{
    public class SSD256Go : IStorage
    {
        private double _price = 40;

        public double GetPrice() {
            return _price;
        }
    }
}