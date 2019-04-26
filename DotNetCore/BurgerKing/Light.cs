namespace BurgerKing
{
    public class Light : IQuantity
    {
        public double PriceAddition { get; set; }

        public Light() 
        {
            PriceAddition = 1;
        }
    }
}