using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Real.Interfaces
{
    public abstract class Pizzeria
    {
        protected abstract IPizza CreatePizza(string type);
        
        public IPizza OrderPizza(string type)
        {
            IPizza pizza = CreatePizza(type);

            pizza.Prepare(ingredients);
            pizza.Cooking();
            pizza.Cutting();
            pizza.AddInBox();
            pizza.Delivery();

            return pizza;
        }
    }
}
