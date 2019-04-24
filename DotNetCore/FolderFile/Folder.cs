using System.Collections.Generic;

namespace FolderFile
{
    public class Folder : IElement
    {
        public string Name { get; set; }

        public List<IElement> Elements { get; private set; }

        public Folder (string name) 
        {
            Name = name;
        }

        public void Add(IElement element)
        {
            if(Elements == null)
                Elements = new List<IElement>();
            

            if(NameAlreadyExists(element.Name))
                throw new NameAlreadyExistsException();
            else
                Elements.Add(element);
        }

        public bool NameAlreadyExists(string name)
        {
            if(Elements != null)
            {
                foreach(IElement element in Elements)
                {
                    if (element.Name == name)
                        return true;
                }
            }

            return false;
        }
        
        public int GetContainsNumber()
        {
            return Elements == null ? 0 : Elements.Count;
        }

        public void Accept(IWriter writer)
        {
            writer.Write(this);
        }
    }
}
