namespace ShoesFabric
{
    public class LeatherFabric : IShoeCreator
    {
        public StreetShoe CreateShoe() 
        {
            return new LeatherStreetShoe();
        }

        public Sandal CreateSandal() 
        {
            return new LeatherSandal();
        }
    }
}