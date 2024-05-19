using DesignPatterns.AbstractFactory.Interfaces;


namespace DesignPatterns.AbstractFactory
{
    internal class ConcreteFactoryOne : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductAOne();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductBOne();
        }
    }
}
