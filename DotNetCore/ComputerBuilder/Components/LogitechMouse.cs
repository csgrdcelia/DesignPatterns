namespace ComputerBuilderNs
{
    public class LogitechMouse : IMouse
    {
        private double _price = 8;

        public double GetPrice() {
            return _price;
        }   
    }
}