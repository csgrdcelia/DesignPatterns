namespace BurgerKing
{
    public class Plenty : IQuantity
    {
        public double PriceAddition { get; set; }

        public Plenty() 
        {
            PriceAddition = 3;
        }
    }
}