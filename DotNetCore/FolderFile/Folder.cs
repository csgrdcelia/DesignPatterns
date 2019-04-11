using System.Collections.Generic;

namespace FolderFile
{
    public class Folder : IElement
    {
        public string Name { get; set; }

        public List<IElement> Elements { get; set; }

        public Folder (string name) 
        {
            Name = name;
        }
        
        public int GetContainsNumber()
        {
            return Elements == null ? 0 : Elements.Count;
        }
    }
}
