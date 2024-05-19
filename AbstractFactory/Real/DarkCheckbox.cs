using DesignPatterns.AbstractFactory.Real.Interfaces;
using System;

namespace DesignPatterns.AbstractFactory.Real
{
    internal class DarkCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a checkbox in Dark theme.");
        }
    }
}