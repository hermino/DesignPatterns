using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class ConcreteProductBTwo : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the product BTwo collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product BTwo";
        }
    }
}