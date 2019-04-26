namespace BurgerKing
{
    public class Normal : IQuantity
    {
        public double PriceAddition { get; set; }

        public Normal() 
        {
            PriceAddition = 2;
        }
    }
}