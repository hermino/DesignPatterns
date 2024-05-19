using DesignPatterns.AbstractFactory.Interfaces;
using System;

namespace DesignPatterns.AbstractFactory
{
    class ClientAbstractFactory
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactoryOne());
            Console.WriteLine();

            Console.WriteLine("Client: Testing client code with the second factory type...");
            ClientMethod(new ConcreteFactoryTwo());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
