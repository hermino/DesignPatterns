using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;


namespace DesignPatterns.FactoryMethod.Real
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(List<string> ingredients) : base(ingredients) { }

        public override void AddInBox() => Console.WriteLine("Add pepperoni pizza in a box...");

        public override void Cooking() => Console.WriteLine("Cooking pepperoni pizza...");

        public override void Cutting() => Console.WriteLine("Cutting pepperoni pizza...");

        public override void Delivery() => Console.WriteLine("Your pepperoni pizza is coming to your house!");

        public override void Prepare() => Console.WriteLine($"Adding ingredients ({String.Join(", ", this.ingredients)}) on pepperoni pizza!");
    }
}
