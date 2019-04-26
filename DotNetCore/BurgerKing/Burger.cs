using System;
using System.Collections.Generic;
namespace BurgerKing
{
    public class Burger
    {
        private IBread _bread;
        private List<Tuple<IIngredient, IQuantity>> _ingredients;

        public Burger(IBread bread, List<Tuple<IIngredient, IQuantity>> ingredients)
        {
            _bread = bread;
            _ingredients = ingredients;
        }
    }
}