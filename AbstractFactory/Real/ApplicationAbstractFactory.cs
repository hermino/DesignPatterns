using DesignPatterns.AbstractFactory.Real.Interfaces;
using DesignPatterns.AbstractFactory.Real;


namespace DesignPatterns.AbstractFactory
{
    internal class ApplicationAbstractFactory
    {
        public void Main()
        {
            IGUIFactory factory;
            string theme = "dark";

            if (theme.Equals("light"))
            {
                factory = new LightTheme();
            }
            else
            {
                factory = new DarkTheme();
            }

            Application app = new Application(factory);
            app.paint();
        }
    }
}
