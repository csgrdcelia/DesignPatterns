namespace ComputerBuilderNs
{
    public class I7 : ICPU
    {
        private double _price = 150;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "SSD256Go";
        }
    }
}