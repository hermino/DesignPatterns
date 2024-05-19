using DesignPatterns.AbstractFactory.Real.Interfaces;
using System;

namespace DesignPatterns.AbstractFactory.Real
{
    internal class DarkButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in Dark theme.");
        }
    }
}