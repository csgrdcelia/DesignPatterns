using System.Collections.Generic;
namespace AtDentist
{
    public interface IIterable
    {
        Queue<Patient> patients { get; set; }
        IIterator GetIterator();
    }
}