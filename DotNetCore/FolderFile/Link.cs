
namespace FolderFile
{
    public class Link : IElement
    {
        public string Name { get; set; }
        public IElement Element { get; set; }

        public Link (string name, IElement element) 
        {
            Name = name;
            Element = element;
        }
    }
}