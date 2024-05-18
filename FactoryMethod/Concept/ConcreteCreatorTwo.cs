using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    class ConcreteCreatorTwo : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductTwo();
        }
    }
}