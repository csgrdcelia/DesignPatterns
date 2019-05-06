namespace PCMaker
{
    public interface IPCBuilder 
    {
        PCBuilder AddComponent(IComponent component);
        PC GetProduct();
    }
}