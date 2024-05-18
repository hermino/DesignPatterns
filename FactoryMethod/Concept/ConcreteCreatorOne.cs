using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    class ConcreteCreatorOne : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductOne();
        }
    }
}