using System;
namespace Creperie
{
    public class Crepe : IDessert
    {
        private Double price = 10;
        public Crepe() 
        {
        
        }
        public Double GetPrice() {
            return price;
        }
    }
}