namespace BurgerKing
{
    public class Ketchup : IExtra
    {
        private double _price;
        public IQuantity Quantity { get; set; }
        public IIngredient Ingredient { get; set; }

        public Ketchup(IQuantity quantity, IIngredient ingredient) 
        {
            Quantity = quantity;
            Ingredient = ingredient;
            _price = 1;
        }

        public double GetPrice() 
        {
            return _price + Quantity.PriceAddition + Ingredient.GetPrice();
        }
        
    }
}