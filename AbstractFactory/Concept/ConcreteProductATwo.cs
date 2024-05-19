using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class ConcreteProductATwo : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product ATwo";
        }
    }
}