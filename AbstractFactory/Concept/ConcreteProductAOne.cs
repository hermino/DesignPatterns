using DesignPatterns.AbstractFactory.Interfaces;


namespace DesignPatterns.AbstractFactory
{
    internal class ConcreteProductAOne : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product AOne";
        }
    }
}