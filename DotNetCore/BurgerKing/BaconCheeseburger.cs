namespace BurgerKing
{
    public class BaconCheeseburger : IIngredient
    {
        private double _price;

        public BaconCheeseburger() 
        {
            _price = 11;
        }

        public double GetPrice() 
        {
            return _price;
        }
    }
}