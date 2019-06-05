using System.ComponentModel;
using System.Collections.Generic;
namespace ComputerBuilderNs
{
    public class FlyweightFabric
    {
        Dictionary<string, IComponent> flyweights;

        public FlyweightFabric() 
        {
            flyweights = new Dictionary<string, IComponent>();
        }

        public IComponent GetFlyweight(string key) {
            IComponent component = null;

            if (flyweights.ContainsKey(key)) 
            {
                component =  flyweights[key];
            } else 
            {
                component = new Component(key).Get();
                flyweights.Add(component.GetKey(), component);
            }
            return component;
        }
    }
}