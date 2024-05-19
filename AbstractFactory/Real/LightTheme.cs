using DesignPatterns.AbstractFactory.Real.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Real
{
    internal class LightTheme : IGUIFactory
    {
        public IButton createButton()
        {
            return new LightButton();
        }

        public ICheckbox createCheckbox()
        {
            return new LightCheckbox();
        }

        public IWindow createWindow()
        {
            return new LightWindow();
        }
    }
}
