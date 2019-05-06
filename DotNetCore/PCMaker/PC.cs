using System.Collections.Generic;

namespace PCMaker
{
    public class PC
    {
        private List<IComponent> _components;

        public PC(List<IComponent> components)
        {
            _components = components;
        }
    }
}