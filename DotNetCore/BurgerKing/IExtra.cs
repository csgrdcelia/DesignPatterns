namespace BurgerKing
{
    public interface IExtra : IIngredient
    {
        IIngredient Ingredient { get; set; }
        IQuantity Quantity { get; set; }
    }
}