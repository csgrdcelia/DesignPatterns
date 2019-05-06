namespace ComputerBuilderNs
{
    public class LogitechKeyboard : IKeyboard
    {
        private double _price = 10;

        public double GetPrice() {
            return _price;
        }
    }
}