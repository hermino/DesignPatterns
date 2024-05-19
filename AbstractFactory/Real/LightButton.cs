using DesignPatterns.AbstractFactory.Real.Interfaces;
using System;

namespace DesignPatterns.AbstractFactory.Real
{
    internal class LightButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in Light theme.");
        }
    }
}