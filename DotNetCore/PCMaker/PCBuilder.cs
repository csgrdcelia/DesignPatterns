
using System;
using System.Collections.Generic;

namespace PCMaker
{
    public class PCBuilder : IPCBuilder
    {
        List<IComponent> _components;

        public PCBuilder()
        {
            _components = new List<IComponent>();
        }

        public PCBuilder AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public double GetActualPrice() 
        {
            
        }

        public PC GetProduct() 
        {
            return new PC(_components);
        }
    }
}