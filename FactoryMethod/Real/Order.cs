using DesignPatterns.FactoryMethod.Real.Interfaces;


namespace DesignPatterns.FactoryMethod.Real
{
    internal class Order
    {
        public void Main() { 
            Pizzeria pizzeria = new ItalianPizzeria();
            pizzeria.OrderPizza("margherita");
        }
    }
}
