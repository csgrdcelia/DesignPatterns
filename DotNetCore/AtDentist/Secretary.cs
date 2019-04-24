namespace AtDentist
{
    public class Secretary : IIterator
    {
        public bool HasNext() 
        {
            return true;
        }

        public IElement Next() 
        {
            return new Patient();
        }
    }
}