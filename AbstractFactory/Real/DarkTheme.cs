using DesignPatterns.AbstractFactory.Real.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Real
{
    internal class DarkTheme: IGUIFactory
    {
        public IButton createButton()
        {
            return new DarkButton();
        }

        public ICheckbox createCheckbox()
        {
            return new DarkCheckbox();
        }

        public IWindow createWindow()
        {
            return new DarkWindow();
        }
    }
}
