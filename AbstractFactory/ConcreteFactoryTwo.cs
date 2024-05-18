using DesignPatterns.AbstractFactory.Interfaces;


namespace DesignPatterns.AbstractFactory
{
    internal class ConcreteFactoryTwo : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductATwo();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductBTwo();
        }
    }
}
