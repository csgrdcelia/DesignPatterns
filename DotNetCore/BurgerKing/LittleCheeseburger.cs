namespace BurgerKing
{
    public class LittleCheeseburger : IIngredient
    {
        private double _price;

        public LittleCheeseburger() 
        {
            _price = 7;
        }

        public double GetPrice() 
        {
            return _price;
        }
    }
}