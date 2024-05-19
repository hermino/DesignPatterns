using DesignPatterns.AbstractFactory.Real.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Real
{
    internal class Application
    {
        private IButton button;
        private ICheckbox checkbox;
        private IWindow window;

        public Application(IGUIFactory factory)
        {
            this.button = factory.createButton();
            this.checkbox = factory.createCheckbox();
            this.window = factory.createWindow();
        }

        public void paint()
        {
            this.button.Paint();
            this.checkbox.Paint();
            this.window.Paint();    
        }
    }
}
