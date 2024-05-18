using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    class ConcreteProductTwo : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductTwo}";
        }
    }
}