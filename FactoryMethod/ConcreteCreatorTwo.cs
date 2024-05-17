namespace DesignPatterns
{
    class ConcreteCreatorTwo : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductTwo();
        }
    }
}