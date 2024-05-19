using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Real;
using DesignPatterns.FactoryMethod;
using DesignPatterns.FactoryMethod.Real;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory method applications: ");
            new ClientFactoryMethod().Main();
            new Order().Main();

            Console.WriteLine();

            Console.WriteLine("Abstract Factory applications: ");
            new ClientAbstractFactory().Main();
            new ApplicationAbstractFactory().Main();
        }
    }
}
