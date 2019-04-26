namespace BurgerKing
{
    public class Cheeseburger : IIngredient
    {
        private double _price;

        public Cheeseburger() 
        {
            _price = 10;
        }

        public double GetPrice() 
        {
            return _price;
        }
    }
}