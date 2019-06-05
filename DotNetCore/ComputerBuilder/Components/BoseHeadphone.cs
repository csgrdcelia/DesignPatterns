namespace ComputerBuilderNs
{
    public class BoseHeadphone : IHeadphone
    {
        private double _price = 170;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "BoseHeadphone";
        }
    }
}