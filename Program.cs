using DesignPatterns.AbstractFactory;
using DesignPatterns.FactoryMethod;
using DesignPatterns.FactoryMethod.Real;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new ClientFactoryMethod().Main();
            //new ClientAbstractFactory().Main();
            new Order().Main();
        }
    }
}
