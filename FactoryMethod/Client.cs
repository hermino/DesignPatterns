using System;

namespace DesignPatterns
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreatorOne.");
            ClientCode(new ConcreteCreatorOne());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreatorTwo.");
            ClientCode(new ConcreteCreatorTwo());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
        }
    }
}