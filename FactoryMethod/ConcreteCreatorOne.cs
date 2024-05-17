namespace DesignPatterns
{
    class ConcreteCreatorOne : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductOne();
        }
    }
}