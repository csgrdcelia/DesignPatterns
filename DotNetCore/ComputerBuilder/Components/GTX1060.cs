namespace ComputerBuilderNs
{
    public class GTX1060 : IGPU
    {
        private double _price = 250;

        public double GetPrice() {
            return _price;
        }
    }
}