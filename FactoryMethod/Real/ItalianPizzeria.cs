using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Real
{
    internal class ItalianPizzeria : Pizzeria
    {
        protected override IPizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "margherita":
                    return new MargheritaPizza(new List<string> { "pizza dough", "tomato", "cheese", "basil", "oregano" });
                case "pepperoni":
                    return new PepperoniPizza(new List<string> { "pizza dough", "tomato", "cheese", "pepperoni", "oregano" });
                default:
                    throw new ArgumentException("Unknown pizza type");
            }
        }
    }
}
