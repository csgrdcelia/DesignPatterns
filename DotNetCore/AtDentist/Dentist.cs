using System;
namespace AtDentist
{
    public class Dentist
    {
        Patients patients;

        public Dentist()
        {
            patients = new Patients();
        }
        public void EnterNext() 
        {
            IIterator iterator = patients.GetIterator();
            if(iterator.HasNext())
                Receive(iterator.Next());

        }

        private void Receive(IElement element)
        {
            Console.WriteLine(element.Name + " a été reçu.");
        }
    }
}