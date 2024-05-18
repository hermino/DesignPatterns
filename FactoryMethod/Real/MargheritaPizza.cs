using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;


namespace DesignPatterns.FactoryMethod.Real
{
    internal class MargheritaPizza : IPizza
    {
        public string AddInBox()
        {
            return "Add margherita pizza in a box...";
        }

        public string Cooking()
        {
            return "Cooking margherita pizza...";
        }

        public string Cutting()
        {
            return "Cutting margherita pizza...";
        }

        public string Delivery()
        {
            return "Your margherita pizza is coming to your house!";
        }

        public string Prepare(List<string> ingredients)
        {
            return $"Adding ingredients ({String.Join(", ", ingredients)}) on margherita pizza!";
        }
    }
}
