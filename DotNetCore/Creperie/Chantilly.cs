using System;
namespace Creperie
{
    public class Chantilly : Extra
    {
        private Double price = 2;
        public IDessert Dessert { get; set; }

        public Chantilly (IDessert dessert)
        {
            this.Dessert = dessert;
        }
        public Double GetPrice() 
        {
            return Dessert.GetPrice() + this.price;
        }
    }
}