namespace ComputerBuilderNs
{
    public class Screen23Inches : IScreen
    {
        private double _price = 100;

        public double GetPrice() {
            return _price;
        }

        public string GetKey() {
            return "Screen23Inches";
        }
    }
}