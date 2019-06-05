using System;
namespace ConcessionnaireFactory
{
    public class CashOrder : Order
    {
        public void Pay() 
        {
            Console.WriteLine("Cash order is paid.");
        }
        public bool Isvalid() 
        {
            return true;
        }
    }
}