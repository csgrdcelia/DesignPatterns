namespace ShoesFabric
{
    public class SyntheticFabric : IShoeCreator
    {
        public StreetShoe CreateShoe() 
        {
            return new SyntheticStreetShoe();
        }

        public Sandal CreateSandal()
        {
            return new SyntheticSandal();
        }
        
    }
}