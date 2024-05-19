using DesignPatterns.AbstractFactory.Real.Interfaces;
using System;

namespace DesignPatterns.AbstractFactory.Real
{
    internal class LightWindow : IWindow
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a window in Light theme.");
        }
    }
}