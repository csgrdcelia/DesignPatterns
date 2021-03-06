using System.Collections.Generic;

namespace FolderFile
{
    public interface IElement
    {
        string Name { get; set; }
        void Accept(IWriter writer);
    }
}
