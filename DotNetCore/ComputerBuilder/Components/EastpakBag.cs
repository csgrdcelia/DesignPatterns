namespace ComputerBuilderNs
{
    public class EastpakBag : IBag
    {
        private double _price = 30;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "EastpakBag";
        }
    }
}