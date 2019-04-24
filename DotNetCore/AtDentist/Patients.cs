using System.Collections.Generic;
namespace AtDentist
{
    public class Patients : IIterable
    {
        public Queue<Patient> patients { get; set; }
        public IIterator GetIterator() 
        {
            return new Secretary();
        }
    }
}