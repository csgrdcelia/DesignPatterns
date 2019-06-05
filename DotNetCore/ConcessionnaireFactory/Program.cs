using System;

namespace ConcessionnaireFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OrderCreator creator = new CashOrderCreator();
            creator.CreateNewOrder();
        }
    }
}
