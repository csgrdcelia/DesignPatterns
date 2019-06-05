namespace ComputerBuilderNs
{
    public class RAM16Go : IRam
    {
        private double _price = 90;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "RAM16Go";
        }
    }
}