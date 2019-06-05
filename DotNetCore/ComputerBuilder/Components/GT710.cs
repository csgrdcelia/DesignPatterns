namespace ComputerBuilderNs
{
    public class GT710 : IGPU
    {
        private double _price = 40;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "GT710";
        }
    }
}