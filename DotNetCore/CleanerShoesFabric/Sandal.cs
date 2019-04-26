namespace CleanerShoesFabric
{
    public class Sandal : IShoe
    {
        public IMaterial Material { get; set; }
        
        public Sandal(IMaterial material) 
        {
            this.Material = material;
        }
    }
}