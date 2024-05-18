using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    class ConcreteProductOne : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductOne}";
        }
    }
}