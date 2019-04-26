using System.Collections.Generic;
using System;
namespace BurgerKing
{
    public class BurgerMaker
    {
        private IBread _bread;
        private List<Tuple<IIngredient, IQuantity>> _ingredients;
        public BurgerMaker(IBread bread) 
        {
            _bread = bread;
            _ingredients = new List<Tuple<IIngredient, IQuantity>>();
        }

        public BurgerMaker Add(Tuple<IIngredient, IQuantity> ingredient) 
        {
            _ingredients.Add(ingredient);

            return this;
        }

        public Burger GetProduct() 
        {
            return new Burger(_bread, _ingredients);
        }

        public double GetPrice() 
        {
            double price = _bread.Price;
            foreach(Tuple<IIngredient, IQuantity> ingredient in _ingredients)
            {
                price += (ingredient.Item1.GetPrice() + ingredient.Item2.PriceAddition);
            }
            return price;
        }
    }
}