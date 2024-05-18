using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class ConcreteProductBOne : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"result of the BOne collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product BOne";
        }
    }
}