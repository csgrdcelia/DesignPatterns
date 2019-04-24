using System;
namespace Creperie
{
    public class Chocolate : Extra
    {
        private Double price = 4;
        public IDessert Dessert { get; set; }

        public Chocolate (IDessert dessert)
        {
            this.Dessert = dessert;
        }
        public Double GetPrice() 
        {
            return Dessert.GetPrice() + this.price;
        }
    }
}