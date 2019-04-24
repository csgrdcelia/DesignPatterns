namespace FolderFile
{
    public class Writer
    {
        public void Write(IElement element)
        {
            element.Accept((IWriter)this);
        }
        public void Write(Link link)
        {
            //do different things
        }
        public void Write(File file)
        {
            //do different things
        }
        public void Write(Folder folder)
        {
            //do different things
        }
    }
}