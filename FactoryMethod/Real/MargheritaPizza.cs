using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;


namespace DesignPatterns.FactoryMethod.Real
{
    internal class MargheritaPizza : Pizza
    {
        public MargheritaPizza(List<string> ingredients) : base(ingredients) { }

        public override void AddInBox() => Console.WriteLine("Add margherita pizza in a box...");

        public override void Cooking() => Console.WriteLine("Cooking margherita pizza...");

        public override void Cutting() => Console.WriteLine("Cutting margherita pizza...");

        public override void Delivery() => Console.WriteLine("Your margherita pizza is coming to your house!");

        public override void Prepare() => Console.WriteLine($"Adding ingredients ({String.Join(", ", this.ingredients)}) on margherita pizza!");
    }
}
