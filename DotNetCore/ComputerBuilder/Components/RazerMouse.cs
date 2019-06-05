namespace ComputerBuilderNs
{
    public class RazerMouse : IMouse
    {
        private double _price = 80;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "RazerMouse";
        }
    }
}