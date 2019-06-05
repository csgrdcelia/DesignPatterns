namespace ComputerBuilderNs
{
    public class HDD1To : IStorage
    {
        private double _price = 40;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "HDD1To";
        }
    }
}