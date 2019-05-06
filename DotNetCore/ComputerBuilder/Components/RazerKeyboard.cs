namespace ComputerBuilderNs
{
    public class RazerKeyboard : IKeyboard
    {
        private double _price = 80;

        public double GetPrice() {
            return _price;
        }
    }
}