using DesignPatterns.AbstractFactory;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ClientFactoryMethod().Main();
            new ClientAbstractFactory().Main();
        }
    }
}
