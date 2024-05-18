using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;


namespace DesignPatterns.FactoryMethod.Real
{
    internal class PepperoniPizza : IPizza
    {
        public string AddInBox()
        {
            return "Add pepperoni pizza in a box...";
        }

        public string Cooking()
        {
            return "Cooking pepperoni pizza...";
        }

        public string Cutting()
        {
            return "Cutting pepperoni pizza...";
        }

        public string Delivery()
        {
            return "Your pepperoni pizza is coming to your house!";
        }

        public string Prepare(List<string> ingredients)
        {
            return $"Adding ingredients ({String.Join(", ", ingredients)}) on pepperoni pizza!";
        }
    }
}
