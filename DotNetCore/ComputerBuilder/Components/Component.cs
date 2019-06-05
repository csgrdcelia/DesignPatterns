using System.ComponentModel;
namespace ComputerBuilderNs
{
    public class Component
    {
        string key;
        public Component(string key) 
        {
            this.key = key;
        }

        public IComponent Get() 
        {
            return new HDD1To();
        }
    }
}