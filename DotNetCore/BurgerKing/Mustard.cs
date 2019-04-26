namespace BurgerKing
{
    public class Mustard : IExtra
    {
        private double _price;
        public IQuantity Quantity { get; set; }
        public IIngredient Ingredient { get; set; }

        public Mustard(IQuantity quantity, IIngredient ingredient) 
        {
            Quantity = quantity;
            Ingredient = ingredient;
            _price = 2;
        }

        public double GetPrice() 
        {
            return _price + Quantity.PriceAddition + Ingredient.GetPrice();
        }
    }
}