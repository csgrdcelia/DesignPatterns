using System;
namespace ConcessionnaireFactory
{
    public class CreditOrder : Order
    {
        public void Pay() 
        {
            Console.WriteLine("Credit order is paid.");
        }
        public bool Isvalid() 
        {
            return true;
        }
    }
}