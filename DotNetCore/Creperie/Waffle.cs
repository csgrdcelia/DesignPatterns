using System;
namespace Creperie
{
    public class Waffle : IDessert
    {
        private Double price = 3;

        public Waffle ()
        {
        }
        public Double GetPrice() 
        {
            return price;
        }
    }
}