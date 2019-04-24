namespace FolderFile
{
    public class File : IElement
    {
        public string Name { get; set; }

        public File (string name) 
        {
            Name = name;
        }
        public void Accept(IWriter writer)
        {
            writer.Write(this);
        }
    }
}
